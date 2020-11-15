﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.134.0)
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

    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class StreamRecordMetadata : IModel<StreamRecordMetadata>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="StreamRecordMetadata"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(StreamRecordMetadata left, StreamRecordMetadata right)
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
        /// Determines whether two objects of type <see cref="StreamRecordMetadata"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(StreamRecordMetadata left, StreamRecordMetadata right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(StreamRecordMetadata other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.StringSerializedId.IsEqualTo(other.StringSerializedId, StringComparer.Ordinal)
                      && this.Tags.IsEqualTo(other.Tags)
                      && this.TypeRepresentationOfId.IsEqualTo(other.TypeRepresentationOfId)
                      && this.TypeRepresentationOfObject.IsEqualTo(other.TypeRepresentationOfObject)
                      && this.TimestampUtc.IsEqualTo(other.TimestampUtc);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as StreamRecordMetadata);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.StringSerializedId)
            .Hash(this.Tags)
            .Hash(this.TypeRepresentationOfId)
            .Hash(this.TypeRepresentationOfObject)
            .Hash(this.TimestampUtc)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public StreamRecordMetadata DeepClone()
        {
            var result = new StreamRecordMetadata(
                                 this.StringSerializedId?.DeepClone(),
                                 this.TypeRepresentationOfId?.DeepClone(),
                                 this.TypeRepresentationOfObject?.DeepClone(),
                                 this.Tags?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 this.TimestampUtc);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="StringSerializedId" />.
        /// </summary>
        /// <param name="stringSerializedId">The new <see cref="StringSerializedId" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StreamRecordMetadata" /> using the specified <paramref name="stringSerializedId" /> for <see cref="StringSerializedId" /> and a deep clone of every other property.</returns>
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
        public StreamRecordMetadata DeepCloneWithStringSerializedId(string stringSerializedId)
        {
            var result = new StreamRecordMetadata(
                                 stringSerializedId,
                                 this.TypeRepresentationOfId?.DeepClone(),
                                 this.TypeRepresentationOfObject?.DeepClone(),
                                 this.Tags?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 this.TimestampUtc);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Tags" />.
        /// </summary>
        /// <param name="tags">The new <see cref="Tags" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StreamRecordMetadata" /> using the specified <paramref name="tags" /> for <see cref="Tags" /> and a deep clone of every other property.</returns>
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
        public StreamRecordMetadata DeepCloneWithTags(IReadOnlyDictionary<string, string> tags)
        {
            var result = new StreamRecordMetadata(
                                 this.StringSerializedId?.DeepClone(),
                                 this.TypeRepresentationOfId?.DeepClone(),
                                 this.TypeRepresentationOfObject?.DeepClone(),
                                 tags,
                                 this.TimestampUtc);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="TypeRepresentationOfId" />.
        /// </summary>
        /// <param name="typeRepresentationOfId">The new <see cref="TypeRepresentationOfId" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StreamRecordMetadata" /> using the specified <paramref name="typeRepresentationOfId" /> for <see cref="TypeRepresentationOfId" /> and a deep clone of every other property.</returns>
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
        public StreamRecordMetadata DeepCloneWithTypeRepresentationOfId(TypeRepresentationWithAndWithoutVersion typeRepresentationOfId)
        {
            var result = new StreamRecordMetadata(
                                 this.StringSerializedId?.DeepClone(),
                                 typeRepresentationOfId,
                                 this.TypeRepresentationOfObject?.DeepClone(),
                                 this.Tags?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 this.TimestampUtc);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="TypeRepresentationOfObject" />.
        /// </summary>
        /// <param name="typeRepresentationOfObject">The new <see cref="TypeRepresentationOfObject" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StreamRecordMetadata" /> using the specified <paramref name="typeRepresentationOfObject" /> for <see cref="TypeRepresentationOfObject" /> and a deep clone of every other property.</returns>
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
        public StreamRecordMetadata DeepCloneWithTypeRepresentationOfObject(TypeRepresentationWithAndWithoutVersion typeRepresentationOfObject)
        {
            var result = new StreamRecordMetadata(
                                 this.StringSerializedId?.DeepClone(),
                                 this.TypeRepresentationOfId?.DeepClone(),
                                 typeRepresentationOfObject,
                                 this.Tags?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 this.TimestampUtc);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="TimestampUtc" />.
        /// </summary>
        /// <param name="timestampUtc">The new <see cref="TimestampUtc" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="StreamRecordMetadata" /> using the specified <paramref name="timestampUtc" /> for <see cref="TimestampUtc" /> and a deep clone of every other property.</returns>
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
        public StreamRecordMetadata DeepCloneWithTimestampUtc(DateTime timestampUtc)
        {
            var result = new StreamRecordMetadata(
                                 this.StringSerializedId?.DeepClone(),
                                 this.TypeRepresentationOfId?.DeepClone(),
                                 this.TypeRepresentationOfObject?.DeepClone(),
                                 this.Tags?.ToDictionary(k => k.Key?.DeepClone(), v => v.Value?.DeepClone()),
                                 timestampUtc);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.Database.Domain.StreamRecordMetadata: StringSerializedId = {this.StringSerializedId?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Tags = {this.Tags?.ToString() ?? "<null>"}, TypeRepresentationOfId = {this.TypeRepresentationOfId?.ToString() ?? "<null>"}, TypeRepresentationOfObject = {this.TypeRepresentationOfObject?.ToString() ?? "<null>"}, TimestampUtc = {this.TimestampUtc.ToString(CultureInfo.InvariantCulture) ?? "<null>"}.");

            return result;
        }
    }
}