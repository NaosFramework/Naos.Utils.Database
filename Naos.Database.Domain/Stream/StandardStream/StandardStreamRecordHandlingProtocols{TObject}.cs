﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StandardStreamRecordHandlingProtocols{TObject}.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using System.Threading.Tasks;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Serialization;

    /// <summary>
    /// Set of protocols to handle a record in a stream.
    /// </summary>
    /// <typeparam name="TObject">The type of the object.</typeparam>
    /// <seealso cref="IStreamReadProtocols{TObject}" />
    /// <seealso cref="IStreamWriteProtocols{TObject}" />
    public class StandardStreamRecordHandlingProtocols<TObject> :
        IStreamRecordHandlingProtocols<TObject>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields", Justification = "Temporary.")]
        private readonly IStandardReadWriteStream stream;

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardStreamRecordHandlingProtocols{TEvent}"/> class.
        /// </summary>
        /// <param name="stream">The stream.</param>
        public StandardStreamRecordHandlingProtocols(
            IStandardReadWriteStream stream)
        {
            stream.MustForArg(nameof(stream)).NotBeNull();
            this.stream = stream;
        }

        /// <inheritdoc />
        public StreamRecord<TObject> Execute(
            TryHandleRecordOp<TObject> operation)
        {
            var delegatedOperation = operation.Standardize();
            var tryHandleResult = this.stream.Execute(delegatedOperation);
            var record = tryHandleResult.RecordToHandle;

            if (record?.Payload == null)
            {
                return null;
            }

            var payload = record.Payload.DeserializePayloadUsingSpecificFactory<TObject>(this.stream.SerializerFactory);
            var result = new StreamRecord<TObject>(record.InternalRecordId, record.Metadata, payload);
            return result;
        }

        /// <inheritdoc />
        public async Task<StreamRecord<TObject>> ExecuteAsync(
            TryHandleRecordOp<TObject> operation)
        {
            var syncResult = this.Execute(operation);
            var result = await Task.FromResult(syncResult);
            return result;
        }
    }
}
