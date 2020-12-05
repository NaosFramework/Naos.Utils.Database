﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TryHandleRecordWithIdOp{TId,TObject}.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using Naos.Protocol.Domain;

    /// <summary>
    /// Handles a record.
    /// </summary>
    /// <typeparam name="TId">Type of the identifier of the record.</typeparam>
    /// <typeparam name="TObject">Type of the object in the record.</typeparam>
    public partial class TryHandleRecordWithIdOp<TId, TObject> : ReturningOperationBase<StreamRecordWithId<TId, TObject>>, ISpecifyResourceLocator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TryHandleRecordWithIdOp{TId, TObject}"/> class.
        /// </summary>
        /// <param name="concern">The concern.</param>
        /// <param name="typeVersionMatchStrategy">The optional type version match strategy; DEFAULT is Any.</param>
        /// <param name="specifiedResourceLocator">The optional locator to use; DEFAULT will assume single locator on stream or throw.</param>
        public TryHandleRecordWithIdOp(
            string concern,
            TypeVersionMatchStrategy typeVersionMatchStrategy = TypeVersionMatchStrategy.Any,
            IResourceLocator specifiedResourceLocator = null)
        {
            this.Concern = concern;
            this.TypeVersionMatchStrategy = typeVersionMatchStrategy;
            this.SpecifiedResourceLocator = specifiedResourceLocator;
        }

        /// <summary>
        /// Gets the concern.
        /// </summary>
        /// <value>The concern.</value>
        public string Concern { get; private set; }

        /// <summary>
        /// Gets the type version match strategy.
        /// </summary>
        /// <value>The type version match strategy.</value>
        public TypeVersionMatchStrategy TypeVersionMatchStrategy { get; private set; }

        /// <inheritdoc />
        public IResourceLocator SpecifiedResourceLocator { get; private set; }
    }
}
