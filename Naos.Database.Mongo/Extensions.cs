﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Extensions.cs" company="Naos">
//    Copyright (c) Naos 2017. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Mongo
{
    using System;

    using Naos.Database.Domain;

    using Spritely.Recipes;

    /// <summary>
    /// Extension methods for types in the namespace.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Throws an exception if the <see cref="BackupDetails"/> is invalid.
        /// </summary>
        /// <param name="backupDetails">The backup details to validate.</param>
        public static void ThrowIfInvalid(this BackupDetails backupDetails)
        {
            new { backupDetails }.Must().NotBeNull().OrThrow();
            new { backupDetails.BackupTo }.Must().NotBeNull().OrThrow();

            if (backupDetails.Device == Device.Url)
            {
                if (string.IsNullOrWhiteSpace(backupDetails.Credential))
                {
                    throw new ArgumentException("Credential cannot be null or whitespace when Device is URL");
                }
            }

            if (!string.IsNullOrWhiteSpace(backupDetails.Name))
            {
                if (backupDetails.Name.Length > 128)
                {
                    throw new ArgumentException("Name cannot be more than 128 characters in length.");
                }
            }

            if (!string.IsNullOrWhiteSpace(backupDetails.Description))
            {
                if (backupDetails.Description.Length > 255)
                {
                    throw new ArgumentException("Description cannot be more than 255 characters in length.");
                }
            }

            if (backupDetails.Cipher != Cipher.NoEncryption)
            {
                if (backupDetails.Encryptor == Encryptor.None)
                {
                    throw new ArgumentException("Encryptor is required when any Cipher != NoEncryption");
                }

                if (string.IsNullOrWhiteSpace(backupDetails.EncryptorName))
                {
                    throw new ArgumentException("EncryptorName is required when any Cipher != NoEncryption.");
                }
            }

            if (backupDetails.ChecksumOption == ChecksumOption.Checksum)
            {
                if (backupDetails.ErrorHandling == ErrorHandling.None)
                {
                    throw new ArgumentException("ErrorHandling cannot be None when using checksum.");
                }
            }
        }

        /// <summary>
        /// Throws an exception if the <see cref="RestoreDetails"/> is invalid.
        /// </summary>
        /// <param name="restoreDetails">The restore details to validate.</param>
        public static void ThrowIfInvalid(this RestoreDetails restoreDetails)
        {
            new { restoreDetails }.Must().NotBeNull().OrThrow();
            new { restoreDetails.RestoreFrom }.Must().NotBeNull().OrThrow();

            if (restoreDetails.Device == Device.Url)
            {
                if (string.IsNullOrWhiteSpace(restoreDetails.Credential))
                {
                    throw new ArgumentException("Credential cannot be null or whitespace when Device is URL");
                }
            }

            if (restoreDetails.ChecksumOption == ChecksumOption.Checksum)
            {
                if (restoreDetails.ErrorHandling == ErrorHandling.None)
                {
                    throw new ArgumentException("ErrorHandling cannot be None when using checksum.");
                }
            }
        }
    }
}