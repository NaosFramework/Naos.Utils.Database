﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.124.0)
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
    public partial class CreateStreamOp<TId> : IModel<CreateStreamOp<TId>>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="CreateStreamOp{TId}"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(CreateStreamOp<TId> left, CreateStreamOp<TId> right)
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
        /// Determines whether two objects of type <see cref="CreateStreamOp{TId}"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(CreateStreamOp<TId> left, CreateStreamOp<TId> right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(CreateStreamOp<TId> other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.StreamRepresentation.IsEqualTo(other.StreamRepresentation)
                      && this.ExistingStreamEncounteredStrategy.IsEqualTo(other.ExistingStreamEncounteredStrategy);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as CreateStreamOp<TId>);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.StreamRepresentation)
            .Hash(this.ExistingStreamEncounteredStrategy)
            .Value;

        /// <inheritdoc />
        public new CreateStreamOp<TId> DeepClone() => (CreateStreamOp<TId>)this.DeepCloneInternal();

        /// <summary>
        /// Deep clones this object with a new <see cref="StreamRepresentation" />.
        /// </summary>
        /// <param name="streamRepresentation">The new <see cref="StreamRepresentation" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CreateStreamOp{TId}" /> using the specified <paramref name="streamRepresentation" /> for <see cref="StreamRepresentation" /> and a deep clone of every other property.</returns>
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
        public CreateStreamOp<TId> DeepCloneWithStreamRepresentation(IStreamRepresentation<TId> streamRepresentation)
        {
            var result = new CreateStreamOp<TId>(
                                 streamRepresentation,
                                 this.ExistingStreamEncounteredStrategy);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ExistingStreamEncounteredStrategy" />.
        /// </summary>
        /// <param name="existingStreamEncounteredStrategy">The new <see cref="ExistingStreamEncounteredStrategy" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CreateStreamOp{TId}" /> using the specified <paramref name="existingStreamEncounteredStrategy" /> for <see cref="ExistingStreamEncounteredStrategy" /> and a deep clone of every other property.</returns>
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
        public CreateStreamOp<TId> DeepCloneWithExistingStreamEncounteredStrategy(ExistingStreamEncounteredStrategy existingStreamEncounteredStrategy)
        {
            var result = new CreateStreamOp<TId>(
                                 (IStreamRepresentation<TId>)DeepCloneInterface(this.StreamRepresentation),
                                 existingStreamEncounteredStrategy);

            return result;
        }

        /// <inheritdoc />
        protected override OperationBase DeepCloneInternal()
        {
            var result = new CreateStreamOp<TId>(
                                 (IStreamRepresentation<TId>)DeepCloneInterface(this.StreamRepresentation),
                                 this.ExistingStreamEncounteredStrategy);

            return result;
        }

        private static TId DeepCloneGeneric(TId value)
        {
            TId result;

            var type = typeof(TId);

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
                else if (value is IDeepCloneable<TId> deepCloneableValue)
                {
                    result = deepCloneableValue.DeepClone();
                }
                else if (value is string valueAsString)
                {
                    result = (TId)(object)valueAsString.Clone().ToString();
                }
                else if (value is global::System.Version valueAsVersion)
                {
                    result = (TId)valueAsVersion.Clone();
                }
                else
                {
                    throw new NotSupportedException(Invariant($"I do not know how to deep clone an object of type '{type.ToStringReadable()}'"));
                }
            }

            return result;
        }

        private static object DeepCloneInterface(object value)
        {
            object result;

            if (ReferenceEquals(value, null))
            {
                result = null;
            }
            else
            {
                var type = value.GetType();

                if (type.IsValueType)
                {
                    result = value;
                }
                else if (value is string valueAsString)
                {
                    result = valueAsString.Clone().ToString();
                }
                else if (value is global::System.Version valueAsVersion)
                {
                    result = valueAsVersion.Clone();
                }
                else
                {
                    var deepCloneableInterface = typeof(IDeepCloneable<>).MakeGenericType(type);

                    if (deepCloneableInterface.IsAssignableFrom(type))
                    {
                        var deepCloneMethod = deepCloneableInterface.GetMethod(nameof(IDeepCloneable<object>.DeepClone));

                        result = deepCloneMethod.Invoke(value, null);
                    }
                    else
                    {
                        throw new NotSupportedException(Invariant($"I do not know how to deep clone an object of type '{type.ToStringReadable()}'"));
                    }
                }
            }

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.Database.Domain.{this.GetType().ToStringReadable()}: StreamRepresentation = {this.StreamRepresentation?.ToString() ?? "<null>"}, ExistingStreamEncounteredStrategy = {this.ExistingStreamEncounteredStrategy.ToString() ?? "<null>"}.");

            return result;
        }
    }
}