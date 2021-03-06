﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StandardStreamRecordWithIdHandlingProtocols{TId}.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Representation.System;
    using OBeautifulCode.Type;

    /// <summary>
    /// Set of protocols to handle <see cref="IEvent"/>'s in a stream.
    /// </summary>
    /// <typeparam name="TId">The type of the identifier.</typeparam>
    /// <seealso cref="IStreamReadWithIdProtocols{TId}" />
    /// <seealso cref="IStreamWriteWithIdProtocols{TId}" />
    public class StandardStreamRecordWithIdHandlingProtocols<TId> :
        IStreamRecordWithIdHandlingProtocols<TId>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields", Justification = "Temporary.")]
        private readonly IStandardReadWriteStream stream;

        private readonly ISyncAndAsyncReturningProtocol<GetResourceLocatorByIdOp<TId>, IResourceLocator> locatorProtocols;

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardStreamRecordWithIdHandlingProtocols{TEvent}"/> class.
        /// </summary>
        /// <param name="stream">The stream.</param>
        public StandardStreamRecordWithIdHandlingProtocols(
            IStandardReadWriteStream stream)
        {
            stream.MustForArg(nameof(stream)).NotBeNull();
            this.stream = stream;
            this.locatorProtocols = stream.ResourceLocatorProtocols.GetResourceLocatorByIdProtocol<TId>();
        }

        /// <inheritdoc />
        public StreamRecordWithId<TId> Execute(
            TryHandleRecordWithIdOp<TId> operation)
        {
            var delegatedOperation = operation.Standardize();
            var tryHandleResult = this.stream.Execute(delegatedOperation);
            var record = tryHandleResult.RecordToHandle;

            if (record?.Payload == null)
            {
                return null;
            }

            var serializer = this.stream.SerializerFactory.BuildSerializer(record.Payload.SerializerRepresentation);
            var id = serializer.Deserialize<TId>(record.Metadata.StringSerializedId);
            var metadata = new StreamRecordMetadata<TId>(
                id,
                record.Metadata.SerializerRepresentation,
                record.Metadata.TypeRepresentationOfId,
                record.Metadata.TypeRepresentationOfObject,
                record.Metadata.Tags,
                record.Metadata.TimestampUtc,
                record.Metadata.ObjectTimestampUtc);

            var result = new StreamRecordWithId<TId>(record.InternalRecordId, metadata, record.Payload);
            return result;
        }

        /// <inheritdoc />
        public async Task<StreamRecordWithId<TId>> ExecuteAsync(
            TryHandleRecordWithIdOp<TId> operation)
        {
            var syncResult = this.Execute(operation);
            var result = await Task.FromResult(syncResult);
            return result;
        }

        /// <inheritdoc />
        public HandlingStatus Execute(
            GetHandlingStatusOfRecordsByIdOp<TId> operation)
        {
            var serializer = this.stream.SerializerFactory.BuildSerializer(this.stream.DefaultSerializerRepresentation);
            var identifierType = typeof(TId).ToRepresentation();
            var items = new List<Tuple<IResourceLocator, StringSerializedIdentifier>>();
            foreach (var id in operation.IdsToMatch)
            {
                var locator = this.locatorProtocols.Execute(new GetResourceLocatorByIdOp<TId>(id));
                var stringSerializedId = serializer.SerializeToString(id);
                var identified = new StringSerializedIdentifier(stringSerializedId, identifierType);
                items.Add(new Tuple<IResourceLocator, StringSerializedIdentifier>(locator, identified));
            }

            var groupedByLocators = items.GroupBy(_ => _.Item1).ToList();
            var delegatedOperations = groupedByLocators.Select(
                                                            _ => new GetHandlingStatusOfRecordsByIdOp(
                                                                operation.Concern,
                                                                _.Select(__ => __.Item2).ToList(),
                                                                operation.HandlingStatusCompositionStrategy,
                                                                operation.VersionMatchStrategy,
                                                                _.Key))
                                                       .ToList();

            var results = delegatedOperations.Select(_ => this.stream.Execute(_)).ToList();
            var result = results.ReduceToCompositeHandlingStatus(operation.HandlingStatusCompositionStrategy);
            return result;
        }

        /// <inheritdoc />
        public async Task<HandlingStatus> ExecuteAsync(
            GetHandlingStatusOfRecordsByIdOp<TId> operation)
        {
            var syncResult = this.Execute(operation);
            var result = await Task.FromResult(syncResult);
            return result;
        }
    }
}
