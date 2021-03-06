﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.154.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Globalization;
    using global::System.Linq;



    using global::OBeautifulCode.Cloning.Recipes;
    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Serialization;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class PutRecordOp : IModel<PutRecordOp>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="PutRecordOp"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(PutRecordOp left, PutRecordOp right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            var result = left.Equals(right);

            return result;
        }

        /// <summary>
        /// Determines whether two objects of type <see cref="PutRecordOp"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(PutRecordOp left, PutRecordOp right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(PutRecordOp other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.Metadata.IsEqualTo(other.Metadata)
                      && this.Payload.IsEqualTo(other.Payload)
                      && this.SpecifiedResourceLocator.IsEqualTo(other.SpecifiedResourceLocator)
                      && this.ExistingRecordEncounteredStrategy.IsEqualTo(other.ExistingRecordEncounteredStrategy)
                      && this.RecordRetentionCount.IsEqualTo(other.RecordRetentionCount)
                      && this.InternalRecordId.IsEqualTo(other.InternalRecordId)
                      && this.VersionMatchStrategy.IsEqualTo(other.VersionMatchStrategy);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as PutRecordOp);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.Metadata)
            .Hash(this.Payload)
            .Hash(this.SpecifiedResourceLocator)
            .Hash(this.ExistingRecordEncounteredStrategy)
            .Hash(this.RecordRetentionCount)
            .Hash(this.InternalRecordId)
            .Hash(this.VersionMatchStrategy)
            .Value;

        /// <inheritdoc />
        public new PutRecordOp DeepClone() => (PutRecordOp)this.DeepCloneInternal();

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        protected override OperationBase DeepCloneInternal()
        {
            var result = new PutRecordOp(
                                 this.Metadata?.DeepClone(),
                                 this.Payload?.DeepClone(),
                                 this.SpecifiedResourceLocator?.DeepClone(),
                                 this.ExistingRecordEncounteredStrategy.DeepClone(),
                                 this.RecordRetentionCount?.DeepClone(),
                                 this.InternalRecordId?.DeepClone(),
                                 this.VersionMatchStrategy.DeepClone());

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.Database.Domain.PutRecordOp: Metadata = {this.Metadata?.ToString() ?? "<null>"}, Payload = {this.Payload?.ToString() ?? "<null>"}, SpecifiedResourceLocator = {this.SpecifiedResourceLocator?.ToString() ?? "<null>"}, ExistingRecordEncounteredStrategy = {this.ExistingRecordEncounteredStrategy.ToString() ?? "<null>"}, RecordRetentionCount = {this.RecordRetentionCount?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, InternalRecordId = {this.InternalRecordId?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, VersionMatchStrategy = {this.VersionMatchStrategy.ToString() ?? "<null>"}.");

            return result;
        }
    }
}