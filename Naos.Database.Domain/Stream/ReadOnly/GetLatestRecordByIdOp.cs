﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetLatestRecordByIdOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using Naos.Protocol.Domain;
    using static System.FormattableString;

    /// <summary>
    /// Gets the latest record with provided identifier.
    /// </summary>
    public partial class GetLatestRecordByIdOp : ReturningOperationBase<StreamRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetLatestRecordByIdOp"/> class.
        /// </summary>
        /// <param name="stringSerializedId">The identifier serialized as a string using the same serializer as the object.</param>
        /// <param name="identifierType">The optional type of the identifier; default is no filter.</param>
        /// <param name="objectType">The optional type of the object; default is no filter.</param>
        /// <param name="typeVersionMatchStrategy">The type version match strategy.</param>
        public GetLatestRecordByIdOp(
            string stringSerializedId,
            TypeRepresentationWithAndWithoutVersion identifierType = null,
            TypeRepresentationWithAndWithoutVersion objectType = null,
            TypeVersionMatchStrategy typeVersionMatchStrategy = TypeVersionMatchStrategy.Any)
        {
            this.StringSerializedId = stringSerializedId;
            this.IdentifierType = identifierType;
            this.ObjectType = objectType;
            this.TypeVersionMatchStrategy = typeVersionMatchStrategy;
        }

        /// <summary>
        /// Gets the string serialized identifier.
        /// </summary>
        /// <value>The string serialized identifier.</value>
        public string StringSerializedId { get; private set; }

        /// <summary>
        /// Gets the type of the identifier.
        /// </summary>
        /// <value>The type of the identifier.</value>
        public TypeRepresentationWithAndWithoutVersion IdentifierType { get; private set; }

        /// <summary>
        /// Gets the type of the object.
        /// </summary>
        /// <value>The type of the object.</value>
        public TypeRepresentationWithAndWithoutVersion ObjectType { get; private set; }

        /// <summary>
        /// Gets the type version match strategy.
        /// </summary>
        /// <value>The type version match strategy.</value>
        public TypeVersionMatchStrategy TypeVersionMatchStrategy { get; private set; }
    }
}
