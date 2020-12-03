﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MemoryStreamRecordHandlingProtocols{TObject}.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Protocol.Memory
{
    using System.Threading.Tasks;
    using Naos.Database.Domain;
    using Naos.Protocol.Domain;

    /// <summary>
    /// Set of protocols to handle <see cref="IEvent"/>'s in a stream.
    /// </summary>
    /// <typeparam name="TObject">The type of the object.</typeparam>
    /// <seealso cref="IStreamReadProtocols{TObject}" />
    /// <seealso cref="IStreamWriteProtocols{TObject}" />
    public partial class MemoryStreamRecordHandlingProtocols<TObject> :
        IStreamRecordHandlingProtocols<TObject>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields", Justification = "Temporary.")]
        private readonly MemoryReadWriteStream stream;

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryStreamRecordHandlingProtocols{TEvent}"/> class.
        /// </summary>
        /// <param name="stream">The stream.</param>
        public MemoryStreamRecordHandlingProtocols(
            MemoryReadWriteStream stream)
        {
            this.stream = stream;
        }

        /// <inheritdoc />
        public StreamRecord<TObject> Execute(
            TryHandleRecordOp<TObject> operation)
        {
            throw new System.NotImplementedException();
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