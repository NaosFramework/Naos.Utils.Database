﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompleteRunningHandleRecordExecutionOpTest.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain.Test
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using FakeItEasy;

    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.Math.Recipes;

    using Xunit;

    using static System.FormattableString;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class CompleteRunningHandleRecordExecutionOpTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static CompleteRunningHandleRecordExecutionOpTest()
        {
            ConstructorArgumentValidationTestScenarios
               .RemoveAllScenarios()
               .AddScenario(
                    () =>
                        new ConstructorArgumentValidationTestScenario<CompleteRunningHandleRecordExecutionOp>
                        {
                            Name = "constructor should throw ArgumentException when parameter 'concern' is reserved scenario",
                            ConstructionFunc = () =>
                                               {
                                                   var referenceObject = A.Dummy<CompleteRunningHandleRecordExecutionOp>();

                                                   var result = new CompleteRunningHandleRecordExecutionOp(
                                                       referenceObject.Id,
                                                       Concerns.RecordHandlingConcern,
                                                       referenceObject.Details,
                                                       referenceObject.SpecifiedResourceLocator,
                                                       referenceObject.Tags);

                                                   return result;
                                               },
                            ExpectedExceptionType = typeof(ArgumentException),
                            ExpectedExceptionMessageContains = new[]
                                                               {
                                                                   "Concern",
                                                                   "reserved",
                                                               },
                        })
               .AddScenario(
                    () =>
                        new ConstructorArgumentValidationTestScenario<CompleteRunningHandleRecordExecutionOp>
                        {
                            Name = "constructor should throw ArgumentNullException when parameter 'concern' is null scenario",
                            ConstructionFunc = () =>
                                               {
                                                   var referenceObject = A.Dummy<CompleteRunningHandleRecordExecutionOp>();

                                                   var result = new CompleteRunningHandleRecordExecutionOp(
                                                       referenceObject.Id,
                                                       null,
                                                       referenceObject.Details,
                                                       referenceObject.SpecifiedResourceLocator,
                                                       referenceObject.Tags);

                                                   return result;
                                               },
                            ExpectedExceptionType = typeof(ArgumentNullException),
                            ExpectedExceptionMessageContains = new[]
                                                               {
                                                                   "concern",
                                                               },
                        })
               .AddScenario(
                    () =>
                        new ConstructorArgumentValidationTestScenario<CompleteRunningHandleRecordExecutionOp>
                        {
                            Name = "constructor should throw ArgumentException when parameter 'concern' is white space scenario",
                            ConstructionFunc = () =>
                                               {
                                                   var referenceObject = A.Dummy<CompleteRunningHandleRecordExecutionOp>();

                                                   var result = new CompleteRunningHandleRecordExecutionOp(
                                                       referenceObject.Id,
                                                       Invariant($"  {Environment.NewLine}  "),
                                                       referenceObject.Details,
                                                       referenceObject.SpecifiedResourceLocator,
                                                       referenceObject.Tags);

                                                   return result;
                                               },
                            ExpectedExceptionType = typeof(ArgumentException),
                            ExpectedExceptionMessageContains = new[]
                                                               {
                                                                   "concern",
                                                                   "white space",
                                                               },
                        });
        }
    }
}