﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CanceledRequestedHandleRecordExecutionEvent.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Event indicating that a requested execution of <see cref="HandleRecordOp"/> has been canceled.
    /// </summary>
    public partial class CanceledRequestedHandleRecordExecutionEvent : EventBase<long>, IHaveDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CanceledRequestedHandleRecordExecutionEvent"/> class.
        /// </summary>
        /// <param name="id">The internal record identifier concerned with this handling sequence (the effective aggregate identifier of a record handling scenario).</param>
        /// <param name="details">The details about the cancellation.</param>
        /// <param name="timestampUtc">The timestamp in UTC.</param>
        public CanceledRequestedHandleRecordExecutionEvent(
            long id,
            string details,
            DateTime timestampUtc)
        : base(id, timestampUtc)
        {
            details.MustForArg(nameof(details)).NotBeNullNorWhiteSpace();

            this.Details = details;
        }

        /// <inheritdoc />
        public string Details { get; private set; }
    }
}
