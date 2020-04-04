﻿// <copyright file="IMessageHandler.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>


namespace GroupChat.Repository
{
   using System.Collections;
   using System.Collections.Generic;
    /// <summary>
    /// this interface contains the abstract methods for database opertations
    /// </summary>
    public interface IMessageHandler
    {
        void AddMessages(UserAndMessage user);
        void DeleteMessages(string userID);
        IEnumerable<UserAndMessage> GetAllMessages();
    }
}