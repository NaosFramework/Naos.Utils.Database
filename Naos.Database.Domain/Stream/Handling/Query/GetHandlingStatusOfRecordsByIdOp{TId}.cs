﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetHandlingStatusOfRecordsByIdOp{TId}.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Gets the composite status of the set of records by specified tag matching on locators found by identifiers.
    /// </summary>
    /// <typeparam name="TId">Type of the identifier.</typeparam>
    public partial class GetHandlingStatusOfRecordsByIdOp<TId> : ReturningOperationBase<HandlingStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetHandlingStatusOfRecordsByIdOp{TId}"/> class.
        /// </summary>
        /// <param name="concern">The handling concern.</param>
        /// <param name="idsToMatch">The object identifiers to treat as a composite status.</param>
        /// <param name="handlingStatusCompositionStrategy">The optional strategy for composing statuses.</param>
        /// <param name="versionMatchStrategy">The optional type version match strategy; DEFAULT is Any.</param>
        public GetHandlingStatusOfRecordsByIdOp(
            string concern,
            IReadOnlyCollection<TId> idsToMatch,
            HandlingStatusCompositionStrategy handlingStatusCompositionStrategy = null,
            VersionMatchStrategy versionMatchStrategy = VersionMatchStrategy.Any)
        {
            concern.MustForArg(nameof(concern)).NotBeNullNorWhiteSpace();

            idsToMatch.MustForArg(nameof(idsToMatch)).NotBeNullNorEmptyEnumerableNorContainAnyNulls();
            versionMatchStrategy.ThrowOnUnsupportedVersionMatchStrategyForType();

            this.Concern = concern;
            this.IdsToMatch = idsToMatch;
            this.HandlingStatusCompositionStrategy = handlingStatusCompositionStrategy;
            this.VersionMatchStrategy = versionMatchStrategy;
        }

        /// <summary>
        /// Gets the handling concern.
        /// </summary>
        /// <value>The handling concern.</value>
        public string Concern { get; private set; }

        /// <summary>
        /// Gets the object identifiers to match.
        /// </summary>
        /// <value>The object identifiers to match.</value>
        public IReadOnlyCollection<TId> IdsToMatch { get; private set; }

        /// <summary>
        /// Gets the handling status composition strategy.
        /// </summary>
        /// <value>The handling status composition strategy.</value>
        public HandlingStatusCompositionStrategy HandlingStatusCompositionStrategy { get; private set; }

        /// <summary>
        /// Gets the type version match strategy.
        /// </summary>
        /// <value>The type version match strategy.</value>
        public VersionMatchStrategy VersionMatchStrategy { get; private set; }
    }
}
