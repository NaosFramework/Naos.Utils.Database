﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumExtensions.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.Enum.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Enum.Recipes
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Globalization;
    using global::System.Linq;
    using global::System.Reflection;

    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    /// <summary>
    /// Adds some convenient extension methods to enums.
    /// </summary>
#if !OBeautifulCodeEnumSolution
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.Enum.Recipes", "See package version number")]
    internal
#else
    public
#endif
    static class EnumExtensions
    {
        private static readonly MethodInfo ToEnumGenericMethodInfo = typeof(EnumExtensions).GetMethods().Single(_ => (_.Name == nameof(ToEnum)) && _.IsGenericMethod);

        /// <summary>
        /// Gets the members/values of a specified enum.
        /// </summary>
        /// <typeparam name="TEnum">The type of enum.</typeparam>
        /// <returns>
        /// The members/values of the specified enum.
        /// For flags enums, returns all individual flags and all combined flags that are defined in the enum.
        /// </returns>
        /// <exception cref="ArgumentException"><typeparamref name="TEnum"/> is not of type <see cref="Enum"/>.</exception>
        [SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Justification = "This is a developer-facing string, not a user-facing string.")]
        public static IReadOnlyCollection<TEnum> GetDefinedEnumValues<TEnum>()
            where TEnum : struct
        {
            if (!typeof(TEnum).IsEnum)
            {
                throw new ArgumentException($"typeof({nameof(TEnum)}).{nameof(Type.IsEnum)} is false");
            }

            var result = Enum.GetValues(typeof(TEnum)).Cast<TEnum>().ToList();

            return result;
        }

        /// <summary>
        /// Gets the members/values of a specified enum.
        /// </summary>
        /// <param name="enumType">The enum type.</param>
        /// <returns>
        /// The members/values of the specified enum.
        /// For flags enums, returns all individual flags and all combined flags that are defined in the enum.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="enumType"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="enumType"/> is not of type <see cref="Enum"/>.</exception>
        [SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Justification = "This is a developer-facing string, not a user-facing string.")]
        public static IReadOnlyCollection<Enum> GetDefinedEnumValues(
            this Type enumType)
        {
            if (enumType == null)
            {
                throw new ArgumentNullException(nameof(enumType));
            }

            if (!enumType.IsEnum)
            {
                throw new ArgumentException($"{nameof(enumType)}.{nameof(Type.IsEnum)} is false");
            }

            var result = Enum.GetValues(enumType).Cast<Enum>().ToList().AsReadOnly();

            return result;
        }

        /// <summary>
        /// Determines if the specified enum is a flags enum.
        /// </summary>
        /// <typeparam name="TEnum">The type of enum.</typeparam>
        /// <returns>
        /// true if the specified enum is a flags enum, otherwise false.
        /// </returns>
        /// <exception cref="ArgumentException"><typeparamref name="TEnum"/> is not of type <see cref="Enum"/>.</exception>
        [SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "This method signature is here for completeness.")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags", Justification = "'Flags' is the most appropriate term here.")]
        [SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Justification = "This is a developer-facing string, not a user-facing string.")]
        public static bool IsFlagsEnum<TEnum>()
            where TEnum : struct
        {
            if (!typeof(TEnum).IsEnum)
            {
                throw new ArgumentException($"typeof({nameof(TEnum)}).{nameof(Type.IsEnum)} is false");
            }

            var result = typeof(TEnum).GetCustomAttributes<FlagsAttribute>().Any();

            return result;
        }

        /// <summary>
        /// Determines if the specified enum is a flags enum.
        /// </summary>
        /// <param name="enumType">The enum type.</param>
        /// <returns>
        /// true if the specified enum is a flags enum, otherwise false.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="enumType"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="enumType"/> is not of type <see cref="Enum"/>.</exception>
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags", Justification = "'Flags' is the most appropriate term here.")]
        [SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Justification = "This is a developer-facing string, not a user-facing string.")]
        public static bool IsFlagsEnum(
            this Type enumType)
        {
            if (enumType == null)
            {
                throw new ArgumentNullException(nameof(enumType));
            }

            if (!enumType.IsEnum)
            {
                throw new ArgumentException($"{nameof(enumType)}.{nameof(Type.IsEnum)} is false");
            }

            var result = enumType.GetCustomAttributes<FlagsAttribute>().Any();

            return result;
        }

        /// <summary>
        /// Gets all possible enum values.
        /// For a flags enum, this means all possible combination of flags,
        /// regardless of whether the combination is defined in the enum itself.
        /// </summary>
        /// <typeparam name="TEnum">The type of enum.</typeparam>
        /// <returns>
        /// All possible enum values.
        /// </returns>
        /// <exception cref="ArgumentException"><typeparamref name="TEnum"/> is not of type <see cref="Enum"/>.</exception>
        [SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Justification = "This is a developer-facing string, not a user-facing string.")]
        public static IReadOnlyCollection<TEnum> GetAllPossibleEnumValues<TEnum>()
            where TEnum : struct
        {
            var enumType = typeof(TEnum);

            if (!enumType.IsEnum)
            {
                throw new ArgumentException($"typeof({nameof(TEnum)}).{nameof(Type.IsEnum)} is false");
            }

            var result = GetAllPossibleEnumValues(enumType).Cast<TEnum>().ToList();

            return result;
        }

        /// <summary>
        /// Gets all possible enum values.
        /// For a flags enum, this means all possible combination of flags,
        /// regardless of whether the combination is defined in the enum itself.
        /// </summary>
        /// <param name="enumType">The enum type.</param>
        /// <returns>
        /// All possible enum values.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="enumType"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="enumType"/> is not of type <see cref="Enum"/>.</exception>
        [SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Justification = "This is a developer-facing string, not a user-facing string.")]
        public static IReadOnlyCollection<Enum> GetAllPossibleEnumValues(
            this Type enumType)
        {
            if (enumType == null)
            {
                throw new ArgumentNullException(nameof(enumType));
            }

            if (!enumType.IsEnum)
            {
                throw new ArgumentException($"{nameof(enumType)}.{nameof(Type.IsEnum)} is false");
            }

            var result = enumType.IsFlagsEnum()
                ? enumType.GetIndividualFlagsInternal().GetCombinations().Select(_ => _.Aggregate((x, y) => x.BitwiseOr(y))).Distinct().ToList()
                : enumType.GetDefinedEnumValues();

            return result;
        }

        /// <summary>
        /// Gets the flags of a flags enum, with a preference for returning combined flags
        /// instead of individual flags where the enum value uses combined flags.
        /// </summary>
        /// <param name="value">The enum value to decompose into it's flags.</param>
        /// <remarks>
        /// Adapted from: <a href="http://stackoverflow.com/a/4171168/356790" />.
        /// </remarks>
        /// <returns>
        /// The flags of the specified enum, with combined flags instead of individual flags where possible.
        /// No bit will be repeated.  Thus, if two combined flags are represented in the value and they
        /// have an overlapping individual flag, only one of those combined flags will be returned and
        /// the other will be decomposed into it's non-overlapping individual flags.
        /// If value is 0, then a collection with only the 0 value is returned.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags", Justification = "'Flags' is the most appropriate term here.")]
        public static IReadOnlyCollection<Enum> GetFlagsCombinedWherePossible(
            this Enum value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            var result = GetFlags(value, GetDefinedEnumValues(value.GetType()).ToArray()).ToList();

            return result;
        }

        /// <summary>
        /// Gets the flags of a flags enum, with a preference for returning combined flags
        /// instead of individual flags where the enum value uses combined flags.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="value">The enum value to decompose into it's flags.</param>
        /// <remarks>
        /// Adapted from: <a href="http://stackoverflow.com/a/4171168/356790" />.
        /// </remarks>
        /// <returns>
        /// The flags of the specified enum, with combined flags instead of individual flags where possible.
        /// No bit will be repeated.  Thus, if two combined flags are represented in the value and they
        /// have an overlapping individual flag, only one of those combined flags will be returned and
        /// the other will be decomposed into it's non-overlapping individual flags.
        /// If value is 0, then a collection with only the 0 value is returned.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
        /// <exception cref="ArgumentException"><typeparamref name="TEnum"/> is not of type <see cref="Enum"/>.</exception>
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags", Justification = "'Flags' is the most appropriate term here.")]
        [SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Justification = "This is a developer-facing string, not a user-facing string.")]
        public static IReadOnlyCollection<TEnum> GetFlagsCombinedWherePossible<TEnum>(
            this Enum value)
            where TEnum : struct
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (!typeof(TEnum).IsEnum)
            {
                throw new ArgumentException($"typeof({nameof(TEnum)}).{nameof(Type.IsEnum)} is false");
            }

            var result = GetFlags(value, GetDefinedEnumValues(value.GetType()).ToArray()).Cast<TEnum>().ToList();

            return result;
        }

        /// <summary>
        /// Checks if there is any overlap between the two <see cref="FlagsAttribute" /> enumerations.
        /// </summary>
        /// <param name="first">First to check.</param>
        /// <param name="second">Second to check.</param>
        /// <returns>Value indicating whether there is any overlap.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="first"/> is null.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="second"/> is null.</exception>
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flag", Justification = "'Flag' is the most appropriate term here.")]
        public static bool HasFlagOverlap(
            this Enum first,
            Enum second)
        {
            if (first == null)
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (second == null)
            {
                throw new ArgumentNullException(nameof(second));
            }

            var ret = first.GetIndividualFlags().Intersect(second.GetIndividualFlags()).Any();

            return ret;
        }

        /// <summary>
        /// Gets the individual flags of a flags enum type.
        /// </summary>
        /// <param name="enumType">The enum type.</param>
        /// <returns>
        /// The individuals flags of the specified flags enum type (includes 0).
        /// If <paramref name="enumType"/> is not a flags enum then all enum values are returned.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="enumType"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="enumType"/> is not of type <see cref="Enum"/>.</exception>
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags", Justification = "'Flags' is the most appropriate term here.")]
        public static IReadOnlyCollection<Enum> GetIndividualFlags(
            this Type enumType)
        {
            var result = enumType.IsFlagsEnum() ?
                enumType.GetIndividualFlagsInternal().ToList() :
                enumType.GetDefinedEnumValues();

            return result;
        }

        /// <summary>
        /// Gets the individual flags of a flags enum type.
        /// </summary>
        /// <typeparam name="TEnum">The type of enum.</typeparam>
        /// <returns>
        /// The individuals flags of the specified flags enum type (includes 0).
        /// If <typeparamref name="TEnum"/> is not a flags enum then all enum values are returned.
        /// </returns>
        /// <exception cref="ArgumentException"><typeparamref name="TEnum"/> is not of type <see cref="Enum"/>.</exception>
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags", Justification = "'Flags' is the most appropriate term here.")]
        [SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Justification = "This is a developer-facing string, not a user-facing string.")]
        public static IReadOnlyCollection<TEnum> GetIndividualFlags<TEnum>()
            where TEnum : struct
        {
            if (!typeof(TEnum).IsEnum)
            {
                throw new ArgumentException($"typeof({nameof(TEnum)}).{nameof(Type.IsEnum)} is false");
            }

            var result = typeof(TEnum).GetIndividualFlags().Cast<TEnum>().ToList();

            return result;
        }

        /// <summary>
        /// Gets the individual flags of a flags enum value.
        /// </summary>
        /// <param name="value">The enum value to decompose into it's individual flags.</param>
        /// <remarks>
        /// Adapted from: <a href="http://stackoverflow.com/a/4171168/356790" />.
        /// </remarks>
        /// <returns>
        /// The individuals flags of the specified flags enum value.
        /// If value is 0, then a collection with only the 0 value is returned.
        /// If the enum is not a flags enum then a collection with the enum value itself is returned.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags", Justification = "'Flags' is the most appropriate term here.")]
        public static IReadOnlyCollection<Enum> GetIndividualFlags(
            this Enum value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            IReadOnlyCollection<Enum> result;

            var enumType = value.GetType();

            if (enumType.IsFlagsEnum())
            {
                result = GetFlags(value, value.GetType().GetIndividualFlagsInternal().ToArray()).ToList();
            }
            else
            {
                result = new[] { value };
            }

            return result;
        }

        /// <summary>
        /// Gets the individual flags of a flags enum value.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="value">The enum value to decompose into it's individual flags.</param>
        /// <remarks>
        /// Adapted from: <a href="http://stackoverflow.com/a/4171168/356790" />.
        /// </remarks>
        /// <returns>
        /// The individuals flags of the specified flags enum value.
        /// If value is 0, then a collection with only the 0 value is returned.
        /// If the enum is not a flags enum then a collection with the enum value itself is returned.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
        /// <exception cref="ArgumentException"><typeparamref name="TEnum"/> is not of type <see cref="Enum"/>.</exception>
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags", Justification = "'Flags' is the most appropriate term here.")]
        [SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Justification = "This is a developer-facing string, not a user-facing string.")]
        public static IReadOnlyCollection<TEnum> GetIndividualFlags<TEnum>(
            this Enum value)
            where TEnum : struct
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (!typeof(TEnum).IsEnum)
            {
                throw new ArgumentException($"typeof({nameof(TEnum)}).{nameof(Type.IsEnum)} is false");
            }

            IReadOnlyCollection<TEnum> result;

            var enumType = value.GetType();

            if (enumType.IsFlagsEnum())
            {
                result = GetFlags(value, value.GetType().GetIndividualFlagsInternal().ToArray()).Cast<TEnum>().ToList();
            }
            else
            {
                result = new[] { value }.Cast<TEnum>().ToArray();
            }

            return result;
        }

        /// <summary>
        /// Parses and converts to the specified string to an enum value.
        /// </summary>
        /// <remarks>
        /// [Flags] Colors { None=0, Red = 1, Green = 2, Blue = 4 }
        /// '0'          => None
        /// '2'          => Green
        /// '7'          => Red | Green | Blue
        /// 'Blue'       => Blue
        /// 'blue'       => Blue (if ignoreCase = true)
        /// 'Red, Green' => Red | Green
        /// 'Red,Green'  => Red | Green
        /// 'red,green'  => Red | Green (if ignoreCase = true)
        /// </remarks>
        /// <typeparam name="TEnum">The type of enum.</typeparam>
        /// <param name="value">The string value to convert.</param>
        /// <param name="ignoreCase">
        /// Optional value indicating whether to operate in case sensitive or case insensitive mode.
        /// Default is operate in case sensitive mode.
        /// Use <c>true</c> to read value in case insensitive mode; <c>false</c> to read value in case sensitive mode.
        /// </param>
        /// <returns>
        /// The enum member/value that corresponds to the specified string value.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="value"/> is white space.</exception>
        /// <exception cref="ArgumentException"><typeparamref name="TEnum"/> does not represent an enumeration.</exception>
        /// <exception cref="ArgumentException">Cannot convert the specified value to an enum member of the <typeparamref name="TEnum"/> enum.</exception>
        public static TEnum ToEnum<TEnum>(
            this string value,
            bool ignoreCase = false)
            where TEnum : struct
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(Invariant($"{nameof(value)} is white space"));
            }

            if (!typeof(TEnum).IsEnum)
            {
                throw new ArgumentException($"typeof({nameof(TEnum)}).{nameof(Type.IsEnum)} is false");
            }

            if (!Enum.TryParse(value, ignoreCase, out TEnum result) || (!GetAllPossibleEnumValues<TEnum>().Contains(result)))
            {
                throw new ArgumentException(Invariant($"Cannot convert the specified value to an enum member of the '{typeof(TEnum).ToStringReadable()}' enum.   Specified value is '{value}'."));
            }

            return result;
        }

        /// <summary>
        /// Parses and converts to the specified string to an enum value.
        /// </summary>
        /// <remarks>
        /// [Flags] Colors { None=0, Red = 1, Green = 2, Blue = 4 }
        /// '0'          => None
        /// '2'          => Green
        /// '7'          => Red | Green | Blue
        /// 'Blue'       => Blue
        /// 'blue'       => Blue (if ignoreCase = true)
        /// 'Red, Green' => Red | Green
        /// 'Red,Green'  => Red | Green
        /// 'red,green'  => Red | Green (if ignoreCase = true)
        /// </remarks>
        /// <param name="value">The string value to convert.</param>
        /// <param name="enumType">The type of the enum.</param>
        /// <param name="ignoreCase">
        /// Optional value indicating whether to operate in case sensitive or case insensitive mode.
        /// Default is operate in case sensitive mode.
        /// Use <c>true</c> to read value in case insensitive mode; <c>false</c> to read value in case sensitive mode.
        /// </param>
        /// <returns>
        /// The enum member/value that corresponds to the specified string value.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="value"/> is white space.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="enumType"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="enumType"/> does not represent an enumeration.</exception>
        /// <exception cref="ArgumentException">Cannot convert the specified value to an enum member of the <paramref name="enumType"/> enum.</exception>
        public static Enum ToEnum(
            this string value,
            Type enumType,
            bool ignoreCase = false)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(Invariant($"{nameof(value)} is white space"));
            }

            if (enumType == null)
            {
                throw new ArgumentNullException(nameof(enumType));
            }

            if (!enumType.IsEnum)
            {
                throw new ArgumentException($"{nameof(enumType)}.{nameof(Type.IsEnum)} is false");
            }

            try
            {
                var result = (Enum)ToEnumGenericMethodInfo.MakeGenericMethod(enumType).Invoke(null, new object[] { value, ignoreCase });

                return result;
            }
            catch (TargetInvocationException ex)
            {
                // ReSharper disable once PossibleNullReferenceException
                throw ex.InnerException;
            }
        }

        /// <summary>
        /// Performs a bitwise OR on the specified enum values.
        /// </summary>
        /// <param name="value1">The first enum value.</param>
        /// <param name="value2">The second enum value.</param>
        /// <returns>
        /// The result of performing a bitwise OR operation on the specified enum values.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="value1"/> is null.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="value2"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="value1"/> is not a flags enum.</exception>
        /// <exception cref="ArgumentException"><paramref name="value1"/> Type != <paramref name="value2"/> Type.</exception>
        public static Enum BitwiseOr(
            this Enum value1,
            Enum value2)
        {
            if (value1 == null)
            {
                throw new ArgumentNullException(nameof(value1));
            }

            if (value2 == null)
            {
                throw new ArgumentNullException(nameof(value2));
            }

            var value1Type = value1.GetType();
            var value2Type = value2.GetType();

            if (!value1Type.IsFlagsEnum())
            {
                throw new ArgumentException($"{nameof(value1)}.{nameof(GetType)}().{nameof(IsFlagsEnum)}() is false");
            }

            if (!(value1Type == value2Type))
            {
                throw new ArgumentException($"{nameof(value1)}.{nameof(GetType)}() == {nameof(value2)}.{nameof(GetType)}() is false");
            }

            Enum result;

            if (Enum.GetUnderlyingType(value1Type) != typeof(ulong))
            {
                result = (Enum)Enum.ToObject(value1Type, Convert.ToInt64(value1, CultureInfo.InvariantCulture) | Convert.ToInt64(value2, CultureInfo.InvariantCulture));
            }
            else
            {
                result = (Enum)Enum.ToObject(value1Type, Convert.ToUInt64(value1, CultureInfo.InvariantCulture) | Convert.ToUInt64(value2, CultureInfo.InvariantCulture));
            }

            return result;
        }

        private static IEnumerable<Enum> GetFlags(
            Enum value,
            IList<Enum> values)
        {
            ulong bits = Convert.ToUInt64(value, CultureInfo.InvariantCulture);
            List<Enum> results = new List<Enum>();
            for (int i = values.Count - 1; i >= 0; i--)
            {
                ulong mask = Convert.ToUInt64(values[i], CultureInfo.InvariantCulture);
                if (i == 0 && mask == 0L)
                {
                    break;
                }

                if ((bits & mask) == mask)
                {
                    results.Add(values[i]);
                    bits -= mask;
                }
            }

            if (bits != 0L)
            {
                return Enumerable.Empty<Enum>();
            }

            if (Convert.ToUInt64(value, CultureInfo.InvariantCulture) != 0L)
            {
                return results.Reverse<Enum>();
            }

            if (bits == Convert.ToUInt64(value, CultureInfo.InvariantCulture) && values.Count > 0 &&
                Convert.ToUInt64(values[0], CultureInfo.InvariantCulture) == 0L)
            {
                return values.Take(1);
            }

            return Enumerable.Empty<Enum>();
        }

        private static IEnumerable<Enum> GetIndividualFlagsInternal(
            this Type enumType)
        {
            // this method will NOT work for a regular enums, has to be a flags enum
            ulong flag = 0x1;
            foreach (var value in Enum.GetValues(enumType).Cast<Enum>())
            {
                ulong bits = Convert.ToUInt64(value);
                if (bits == 0L)
                {
                    yield return value;
                }

                while (flag < bits)
                {
                    flag <<= 1;
                }

                if (flag == bits)
                {
                    yield return value;
                }
            }
        }
    }
}