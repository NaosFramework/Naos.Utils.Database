﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.135.0)
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

    using global::Naos.Protocol.Domain;

    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class GetStreamFromRepresentationOp<TStreamRepresentation, TStream> : IModel<GetStreamFromRepresentationOp<TStreamRepresentation, TStream>>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="GetStreamFromRepresentationOp{TStreamRepresentation, TStream}"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(GetStreamFromRepresentationOp<TStreamRepresentation, TStream> left, GetStreamFromRepresentationOp<TStreamRepresentation, TStream> right)
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
        /// Determines whether two objects of type <see cref="GetStreamFromRepresentationOp{TStreamRepresentation, TStream}"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(GetStreamFromRepresentationOp<TStreamRepresentation, TStream> left, GetStreamFromRepresentationOp<TStreamRepresentation, TStream> right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(GetStreamFromRepresentationOp<TStreamRepresentation, TStream> other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.TypedStreamRepresentation.IsEqualTo(other.TypedStreamRepresentation);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as GetStreamFromRepresentationOp<TStreamRepresentation, TStream>);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.TypedStreamRepresentation)
            .Value;

        /// <inheritdoc />
        public new GetStreamFromRepresentationOp<TStreamRepresentation, TStream> DeepClone() => (GetStreamFromRepresentationOp<TStreamRepresentation, TStream>)this.DeepCloneInternal();

        /// <summary>
        /// Deep clones this object with a new <see cref="TypedStreamRepresentation" />.
        /// </summary>
        /// <param name="typedStreamRepresentation">The new <see cref="TypedStreamRepresentation" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="GetStreamFromRepresentationOp{TStreamRepresentation, TStream}" /> using the specified <paramref name="typedStreamRepresentation" /> for <see cref="TypedStreamRepresentation" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002: DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public GetStreamFromRepresentationOp<TStreamRepresentation, TStream> DeepCloneWithTypedStreamRepresentation(TStreamRepresentation typedStreamRepresentation)
        {
            var result = new GetStreamFromRepresentationOp<TStreamRepresentation, TStream>(
                                 typedStreamRepresentation);

            return result;
        }

        /// <inheritdoc />
        protected override OperationBase DeepCloneInternal()
        {
            var result = new GetStreamFromRepresentationOp<TStreamRepresentation, TStream>(
                                 DeepCloneGeneric(this.TypedStreamRepresentation));

            return result;
        }

        private static TStreamRepresentation DeepCloneGeneric(TStreamRepresentation value)
        {
            object result;

            var type = typeof(TStreamRepresentation);

            if (type.IsValueType)
            {
                result = value;
            }
            else
            {
                if (ReferenceEquals(value, null))
                {
                    result = default;
                }
                else if (value is IDeepCloneable<TStreamRepresentation> deepCloneableValue)
                {
                    result = deepCloneableValue.DeepClone();
                }
                else if (value is string valueAsString)
                {
                    result = valueAsString.DeepClone();
                }
                else if (value is global::System.Version valueAsVersion)
                {
                    result = valueAsVersion.DeepClone();
                }
                else if (value is global::System.Uri valueAsUri)
                {
                    result = valueAsUri.DeepClone();
                }
                else
                {
                    throw new NotSupportedException(Invariant($"I do not know how to deep clone an object of type '{type.ToStringReadable()}'"));
                }
            }

            return (TStreamRepresentation)result;
        }

        private static TStream DeepCloneGeneric(TStream value)
        {
            object result;

            var type = typeof(TStream);

            if (type.IsValueType)
            {
                result = value;
            }
            else
            {
                if (ReferenceEquals(value, null))
                {
                    result = default;
                }
                else if (value is IDeepCloneable<TStream> deepCloneableValue)
                {
                    result = deepCloneableValue.DeepClone();
                }
                else if (value is string valueAsString)
                {
                    result = valueAsString.DeepClone();
                }
                else if (value is global::System.Version valueAsVersion)
                {
                    result = valueAsVersion.DeepClone();
                }
                else if (value is global::System.Uri valueAsUri)
                {
                    result = valueAsUri.DeepClone();
                }
                else
                {
                    throw new NotSupportedException(Invariant($"I do not know how to deep clone an object of type '{type.ToStringReadable()}'"));
                }
            }

            return (TStream)result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.Database.Domain.{this.GetType().ToStringReadable()}: TypedStreamRepresentation = {this.TypedStreamRepresentation?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}