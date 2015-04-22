﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cipher.cs" company="Naos">
//   Copyright 2015 Naos
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Tools.Backup
{
    /// <summary>
    /// Specifies the algorithm used to encrypt/decrypt backups.
    /// </summary>
    public enum Cipher
    {
        /// <summary>
        /// No encryption.
        /// </summary>
        NoEncryption,

        /// <summary>
        /// Use AES 128.
        /// </summary>
        Aes128,

        /// <summary>
        /// Use AES 192.
        /// </summary>
        Aes192,

        /// <summary>
        /// Use AES 256.
        /// </summary>
        Aes256,

        /// <summary>
        /// Use triple DES.
        /// </summary>
        TripleDes3Key,
    }
}