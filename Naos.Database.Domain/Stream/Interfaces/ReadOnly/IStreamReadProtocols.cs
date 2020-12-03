﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStreamReadProtocols.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using Naos.CodeAnalysis.Recipes;
    using Naos.Protocol.Domain;

    /// <summary>
    /// Interface to protocol the basic stream data operations without a known identifier.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces", Justification = NaosSuppressBecause.CA1040_AvoidEmptyInterfaces_NeedToIdentifyGroupOfTypesAndPreferInterfaceOverAttribute)]
    public interface IStreamReadProtocols
        : ISyncAndAsyncReturningProtocol<GetLatestRecordOp, StreamRecord>,
          ISyncAndAsyncReturningProtocol<GetLatestRecordByIdOp, StreamRecord>
    {
    }
}
