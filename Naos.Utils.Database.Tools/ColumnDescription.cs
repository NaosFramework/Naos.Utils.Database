﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ColumnDescription.cs" company="Naos">
//   Copyright 2014 Naos
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Utils.Database.Tools
{
    /// <summary>
    /// Detailed information about the column.
    /// </summary>
    public class ColumnDescription
    {
        #region Properties

        /// <summary>
        /// Gets or sets the name of the column.
        /// </summary>
        public string ColumnName { get; set; }

        /// <summary>
        /// Gets or sets the ordinal position of the column.
        /// </summary>
        public int OrdinalPosition { get; set; }

        /// <summary>
        /// Gets or sets the default value of the column.
        /// </summary>
        public string ColumnDefault { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the column is nullable.
        /// </summary>
        public bool IsNullable { get; set; }

        /// <summary>
        /// Gets or sets the data type of the column.
        /// </summary>
        public string DataType { get; set; }

        #endregion
    }
}
