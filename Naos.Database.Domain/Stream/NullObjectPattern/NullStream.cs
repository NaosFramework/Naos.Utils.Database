﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NullStream.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using System;
    using Naos.CodeAnalysis.Recipes;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// A null object to be used as the id of an object in a <see cref="IReadWriteStream"/> that does not have an actual identifier.
    /// </summary>
    public partial class NullReadWriteStream : IReadWriteStream
    {
        /// <inheritdoc />
        public string Name => nameof(NullReadWriteStream);

        /// <inheritdoc />
        public IStreamRepresentation StreamRepresentation => new NullStreamRepresentation();

        /// <inheritdoc />
        public IResourceLocatorProtocols ResourceLocatorProtocols => throw new NotImplementedException();

        /// <inheritdoc />
        public IStreamReadProtocols GetStreamReadingProtocols()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IStreamReadProtocols<TObject> GetStreamReadingProtocols<TObject>()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IStreamReadProtocols<TId, TObject> GetStreamReadingProtocols<TId, TObject>()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IStreamWriteProtocols GetStreamWritingProtocols()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IStreamWriteProtocols<TObject> GetStreamWritingProtocols<TObject>()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IStreamWriteProtocols<TId, TObject> GetStreamWritingProtocols<TId, TObject>()
        {
            throw new NotImplementedException();
        }
    }
}
