﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.125.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Domain.Test
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;

    using global::FakeItEasy;

    using global::Naos.Database.Domain;
    using global::Naos.Protocol.Domain;

    using global::OBeautifulCode.AutoFakeItEasy;
    using global::OBeautifulCode.Math.Recipes;
    using global::OBeautifulCode.Representation.System;

    /// <summary>
    /// The default (code generated) Dummy Factory.
    /// Derive from this class to add any overriding or custom registrations.
    /// </summary>
    [ExcludeFromCodeCoverage]
    [GeneratedCode("OBeautifulCode.CodeGen.ModelObject", "1.0.125.0")]
#if !NaosDatabaseSolution
    internal
#else
    public
#endif
    abstract class DefaultDatabaseDummyFactory : IDummyFactory
    {
        public DefaultDatabaseDummyFactory()
        {
            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new Block<Version>(
                                 A.Dummy<Version>(),
                                 A.Dummy<DateTime>(),
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyDictionary<string, string>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new CancelBlock<Version>(
                                 A.Dummy<Version>(),
                                 A.Dummy<DateTime>(),
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyDictionary<string, string>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new Pruned<Version>(
                                 A.Dummy<Version>(),
                                 A.Dummy<DateTime>(),
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyDictionary<string, string>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new PruneRequested<Version>(
                                 A.Dummy<Version>(),
                                 A.Dummy<DateTime>(),
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyDictionary<string, string>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new Pruning<Version>(
                                 A.Dummy<Version>(),
                                 A.Dummy<DateTime>(),
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyDictionary<string, string>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new CreateStreamOp<Version>(
                                 A.Dummy<IStreamRepresentation<Version>>(),
                                 A.Dummy<ExistingStreamEncounteredStrategy>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new DeleteStreamOp<Version>(
                                 A.Dummy<IStreamRepresentation<Version>>(),
                                 A.Dummy<ExistingStreamNotEncounteredStrategy>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new GetLatestByIdAndTypeOp<Version, Version>(
                                 A.Dummy<Version>(),
                                 A.Dummy<TypeVersionMatchStrategy>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new GetOp<Version>());

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new GetStreamFromRepresentationOp<Version>(
                                 A.Dummy<StreamRepresentation<Version>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new PutOp<Version>(
                                 A.Dummy<Version>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var availableTypes = new[]
                    {
                        typeof(FileSystemDatabaseLocator),
                        typeof(MemoryDatabaseLocator),
                        typeof(NullDatabaseLocator)
                    };

                    var randomIndex = ThreadSafeRandom.Next(0, availableTypes.Length);

                    var randomType = availableTypes[randomIndex];

                    var result = (DatabaseLocatorBase)AD.ummy(randomType);

                    return result;
                });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new FileSystemDatabaseLocator(
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new MemoryDatabaseLocator(
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new NullDatabaseLocator());

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new FileStreamRepresentation<Version>(
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyList<FileSystemDatabaseLocator>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new MemoryStreamRepresentation<Version>(
                                 A.Dummy<string>(),
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var availableTypes = new[]
                    {
                        typeof(FileStreamRepresentation<Version>),
                        typeof(MemoryStreamRepresentation<Version>),
                        typeof(StreamRepresentation<Version>)
                    };

                    var randomIndex = ThreadSafeRandom.Next(0, availableTypes.Length);

                    var randomType = availableTypes[randomIndex];

                    var result = (StreamRepresentationBase<Version>)AD.ummy(randomType);

                    return result;
                });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new StreamRepresentation<Version>(
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new StreamRecordMetadata<Version>(
                                 A.Dummy<Version>(),
                                 A.Dummy<IReadOnlyDictionary<string, string>>(),
                                 A.Dummy<TypeRepresentation>(),
                                 A.Dummy<TypeRepresentation>(),
                                 A.Dummy<DateTime>()));
        }

        /// <inheritdoc />
        public Priority Priority => new FakeItEasy.Priority(1);

        /// <inheritdoc />
        public bool CanCreate(Type type)
        {
            return false;
        }

        /// <inheritdoc />
        public object Create(Type type)
        {
            return null;
        }
    }
}