﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShareDatabaseNameMessageHandler.cs" company="Naos">
//   Copyright 2015 Naos
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.MessageBus.Handler
{
    using System.Threading.Tasks;

    using Its.Log.Instrumentation;

    using Naos.Database.MessageBus.Contract;
    using Naos.MessageBus.Domain;

    /// <summary>
    /// Naos.MessageBus handler for Share.
    /// </summary>
    public class ShareDatabaseNameMessageHandler : IHandleMessages<ShareDatabaseNameMessage>, IShareDatabaseName
    {
        /// <inheritdoc />
        public async Task HandleAsync(ShareDatabaseNameMessage message)
        {
            using (var log = Log.Enter(() => new { Message = message, DatabaseNameToShare = message.DatabaseNameToShare }))
            {
                log.Trace(() => "Sharing database name: " + message.DatabaseNameToShare);
                this.DatabaseName = await Task.FromResult(message.DatabaseNameToShare);
            }
        }

        /// <inheritdoc />
        public string DatabaseName { get; set; }
    }
}
