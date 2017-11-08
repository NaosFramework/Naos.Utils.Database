﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShareDatabaseNameMessageHandlerTest.cs" company="Naos">
//    Copyright (c) Naos 2017. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Test
{
    using Naos.Database.MessageBus.Handler;
    using Naos.Database.MessageBus.Scheduler;

    using Xunit;

    public class ShareDatabaseNameMessageHandlerTest
    {
        [Fact]
        public void Handle_MessageWithName_AssignedToShare()
        {
            // arrange
            var testName = "Monkey";
            var message = new ShareDatabaseNameMessage { DatabaseNameToShare = testName };
            var handler = new ShareDatabaseNameMessageHandler();

            // act
            handler.HandleAsync(message).Wait();

            // assert
            Assert.Equal(testName, message.DatabaseNameToShare);
            Assert.Equal(testName, handler.DatabaseName);
        }
    }
}