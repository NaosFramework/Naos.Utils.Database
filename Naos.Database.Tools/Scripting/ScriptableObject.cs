// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ScriptableObject.cs" company="Naos">
//    Copyright (c) Naos 2017. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Tools
{
    using Microsoft.SqlServer.Management.Smo;

    using Spritely.Recipes;

    /// <summary>
    /// Model object that describes an object that can be scripted.
    /// </summary>
    public class ScriptableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptableObject"/> class.
        /// </summary>
        /// <param name="table">Object that can be scripted.</param>
        public ScriptableObject(Table table)
        {
            new { table }.Must().NotBeNull().OrThrowFirstFailure();

            this.Name = table.Name;
            this.ObjectToScript = table;
            this.DatabaseObjectType = ScriptableObjectType.Table;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptableObject"/> class.
        /// </summary>
        /// <param name="view">Object that can be scripted.</param>
        public ScriptableObject(View view)
        {
            new { view }.Must().NotBeNull().OrThrowFirstFailure();

            this.Name = view.Name;
            this.ObjectToScript = view;
            this.DatabaseObjectType = ScriptableObjectType.View;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptableObject"/> class.
        /// </summary>
        /// <param name="storedProcedure">Object that can be scripted.</param>
        public ScriptableObject(StoredProcedure storedProcedure)
        {
            new { storedProcedure }.Must().NotBeNull().OrThrowFirstFailure();

            this.Name = storedProcedure.Name;
            this.ObjectToScript = storedProcedure;
            this.DatabaseObjectType = ScriptableObjectType.StoredProcedure;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptableObject"/> class.
        /// </summary>
        /// <param name="userDefinedFunction">Object that can be scripted.</param>
        public ScriptableObject(UserDefinedFunction userDefinedFunction)
        {
            new { userDefinedFunction }.Must().NotBeNull().OrThrowFirstFailure();

            this.Name = userDefinedFunction.Name;
            this.ObjectToScript = userDefinedFunction;
            this.DatabaseObjectType = ScriptableObjectType.UserDefinedFunction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptableObject"/> class.
        /// </summary>
        /// <param name="userDefinedDataType">Object that can be scripted.</param>
        public ScriptableObject(UserDefinedDataType userDefinedDataType)
        {
            new { userDefinedDataType }.Must().NotBeNull().OrThrowFirstFailure();

            this.Name = userDefinedDataType.Name;
            this.ObjectToScript = userDefinedDataType;
            this.DatabaseObjectType = ScriptableObjectType.UserDefinedDataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptableObject"/> class.
        /// </summary>
        /// <param name="databaseRole">Object that can be scripted.</param>
        public ScriptableObject(DatabaseRole databaseRole)
        {
            new { databaseRole }.Must().NotBeNull().OrThrowFirstFailure();

            this.Name = databaseRole.Name;
            this.ObjectToScript = databaseRole;
            this.DatabaseObjectType = ScriptableObjectType.DatabaseRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptableObject"/> class.
        /// </summary>
        /// <param name="user">Object that can be scripted.</param>
        public ScriptableObject(User user)
        {
            new { user }.Must().NotBeNull().OrThrowFirstFailure();

            this.Name = user.Name;
            this.ObjectToScript = user;
            this.DatabaseObjectType = ScriptableObjectType.User;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptableObject"/> class.
        /// </summary>
        /// <param name="foreignKey">Object that can be scripted.</param>
        public ScriptableObject(ForeignKey foreignKey)
        {
            new { foreignKey }.Must().NotBeNull().OrThrowFirstFailure();

            this.Name = foreignKey.Name;
            this.ObjectToScript = foreignKey;
            this.DatabaseObjectType = ScriptableObjectType.ForeignKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptableObject"/> class.
        /// </summary>
        /// <param name="index">Object that can be scripted.</param>
        public ScriptableObject(Index index)
        {
            new { index }.Must().NotBeNull().OrThrowFirstFailure();

            this.Name = index.Name;
            this.ObjectToScript = index;
            this.DatabaseObjectType = ScriptableObjectType.Index;
        }

        /// <summary>
        /// Gets the name of the object.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the database type of object.
        /// </summary>
        public ScriptableObjectType DatabaseObjectType { get; private set; }

        /// <summary>
        /// Gets the object to script.
        /// </summary>
        public IScriptable ObjectToScript { get; private set; }
    }

    /// <summary>
    /// Model object to hold a scripted object that can be applied to a different database.
    /// </summary>
    public class ScriptedObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptedObject"/> class.
        /// </summary>
        /// <param name="name">Name of the object.</param>
        /// <param name="databaseObjectType">Database type of object.</param>
        /// <param name="script">Script to create (and drop if configured to produce) the object.</param>
        public ScriptedObject(string name, ScriptableObjectType databaseObjectType, string script)
        {
            this.Name = name;
            this.DatabaseObjectType = databaseObjectType;
            this.Script = script;
        }

        /// <summary>
        /// Gets the name of the object.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the database type of object.
        /// </summary>
        public ScriptableObjectType DatabaseObjectType { get; private set; }

        /// <summary>
        /// Gets the script.
        /// </summary>
        public string Script { get; private set; }
    }

    /// <summary>
    /// Enumeration of scriptable object types.
    /// </summary>
    public enum ScriptableObjectType
    {
        /// <summary>
        /// Database table.
        /// </summary>
        Table,

        /// <summary>
        /// Table foreign key.
        /// </summary>
        ForeignKey,

        /// <summary>
        /// Table or view index.
        /// </summary>
        Index,

        /// <summary>
        /// Database view.
        /// </summary>
        View,

        /// <summary>
        /// Stored procedure.
        /// </summary>
        StoredProcedure,

        /// <summary>
        /// User defined function.
        /// </summary>
        UserDefinedFunction,

        /// <summary>
        /// User defined data type.
        /// </summary>
        UserDefinedDataType,

        /// <summary>
        /// Database role.
        /// </summary>
        DatabaseRole,

        /// <summary>
        /// Database user.
        /// </summary>
        User,
    }
}