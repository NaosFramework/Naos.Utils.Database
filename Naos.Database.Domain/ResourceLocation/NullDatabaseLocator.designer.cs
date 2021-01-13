﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.140.0)
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
    public partial class NullDatabaseLocator : IModel<NullDatabaseLocator>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="NullDatabaseLocator"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(NullDatabaseLocator left, NullDatabaseLocator right)
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
        /// Determines whether two objects of type <see cref="NullDatabaseLocator"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(NullDatabaseLocator left, NullDatabaseLocator right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(NullDatabaseLocator other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = true;

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as NullDatabaseLocator);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Value;

        /// <inheritdoc />
        public new NullDatabaseLocator DeepClone() => (NullDatabaseLocator)this.DeepCloneInternal();

        /// <inheritdoc />
        protected override ResourceLocatorBase DeepCloneInternal()
        {
            var result = new NullDatabaseLocator();

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.Database.Domain.NullDatabaseLocator: <no properties>.");

            return result;
        }
    }
}