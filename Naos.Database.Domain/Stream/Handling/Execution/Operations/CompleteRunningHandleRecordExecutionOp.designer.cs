﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.153.0)
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

    using global::OBeautifulCode.Cloning.Recipes;
    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class CompleteRunningHandleRecordExecutionOp : IModel<CompleteRunningHandleRecordExecutionOp>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="CompleteRunningHandleRecordExecutionOp"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(CompleteRunningHandleRecordExecutionOp left, CompleteRunningHandleRecordExecutionOp right)
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
        /// Determines whether two objects of type <see cref="CompleteRunningHandleRecordExecutionOp"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(CompleteRunningHandleRecordExecutionOp left, CompleteRunningHandleRecordExecutionOp right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(CompleteRunningHandleRecordExecutionOp other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.Id.IsEqualTo(other.Id)
                      && this.Concern.IsEqualTo(other.Concern, StringComparer.Ordinal)
                      && this.Details.IsEqualTo(other.Details, StringComparer.Ordinal)
                      && this.SpecifiedResourceLocator.IsEqualTo(other.SpecifiedResourceLocator)
                      && this.Tags.IsEqualTo(other.Tags);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as CompleteRunningHandleRecordExecutionOp);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.Id)
            .Hash(this.Concern)
            .Hash(this.Details)
            .Hash(this.SpecifiedResourceLocator)
            .Hash(this.Tags)
            .Value;

        /// <inheritdoc />
        public new CompleteRunningHandleRecordExecutionOp DeepClone() => (CompleteRunningHandleRecordExecutionOp)this.DeepCloneInternal();

        /// <summary>
        /// Deep clones this object with a new <see cref="Id" />.
        /// </summary>
        /// <param name="id">The new <see cref="Id" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CompleteRunningHandleRecordExecutionOp" /> using the specified <paramref name="id" /> for <see cref="Id" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
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
        public CompleteRunningHandleRecordExecutionOp DeepCloneWithId(long id)
        {
            var result = new CompleteRunningHandleRecordExecutionOp(
                                 id,
                                 this.Concern?.DeepClone(),
                                 this.Details?.DeepClone(),
                                 this.SpecifiedResourceLocator?.DeepClone(),
                                 this.Tags?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Concern" />.
        /// </summary>
        /// <param name="concern">The new <see cref="Concern" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CompleteRunningHandleRecordExecutionOp" /> using the specified <paramref name="concern" /> for <see cref="Concern" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
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
        public CompleteRunningHandleRecordExecutionOp DeepCloneWithConcern(string concern)
        {
            var result = new CompleteRunningHandleRecordExecutionOp(
                                 this.Id.DeepClone(),
                                 concern,
                                 this.Details?.DeepClone(),
                                 this.SpecifiedResourceLocator?.DeepClone(),
                                 this.Tags?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Details" />.
        /// </summary>
        /// <param name="details">The new <see cref="Details" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CompleteRunningHandleRecordExecutionOp" /> using the specified <paramref name="details" /> for <see cref="Details" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
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
        public CompleteRunningHandleRecordExecutionOp DeepCloneWithDetails(string details)
        {
            var result = new CompleteRunningHandleRecordExecutionOp(
                                 this.Id.DeepClone(),
                                 this.Concern?.DeepClone(),
                                 details,
                                 this.SpecifiedResourceLocator?.DeepClone(),
                                 this.Tags?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="SpecifiedResourceLocator" />.
        /// </summary>
        /// <param name="specifiedResourceLocator">The new <see cref="SpecifiedResourceLocator" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CompleteRunningHandleRecordExecutionOp" /> using the specified <paramref name="specifiedResourceLocator" /> for <see cref="SpecifiedResourceLocator" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
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
        public CompleteRunningHandleRecordExecutionOp DeepCloneWithSpecifiedResourceLocator(IResourceLocator specifiedResourceLocator)
        {
            var result = new CompleteRunningHandleRecordExecutionOp(
                                 this.Id.DeepClone(),
                                 this.Concern?.DeepClone(),
                                 this.Details?.DeepClone(),
                                 specifiedResourceLocator,
                                 this.Tags?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Tags" />.
        /// </summary>
        /// <param name="tags">The new <see cref="Tags" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CompleteRunningHandleRecordExecutionOp" /> using the specified <paramref name="tags" /> for <see cref="Tags" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
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
        public CompleteRunningHandleRecordExecutionOp DeepCloneWithTags(IReadOnlyDictionary<string, string> tags)
        {
            var result = new CompleteRunningHandleRecordExecutionOp(
                                 this.Id.DeepClone(),
                                 this.Concern?.DeepClone(),
                                 this.Details?.DeepClone(),
                                 this.SpecifiedResourceLocator?.DeepClone(),
                                 tags);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        protected override OperationBase DeepCloneInternal()
        {
            var result = new CompleteRunningHandleRecordExecutionOp(
                                 this.Id.DeepClone(),
                                 this.Concern?.DeepClone(),
                                 this.Details?.DeepClone(),
                                 this.SpecifiedResourceLocator?.DeepClone(),
                                 this.Tags?.DeepClone());

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.Database.Domain.CompleteRunningHandleRecordExecutionOp: Id = {this.Id.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Concern = {this.Concern?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Details = {this.Details?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, SpecifiedResourceLocator = {this.SpecifiedResourceLocator?.ToString() ?? "<null>"}, Tags = {this.Tags?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}