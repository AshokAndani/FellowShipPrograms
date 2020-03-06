﻿/// <copyright file="DoubleCheckPattern.cs" company="BridgeLabz">
///     BridgeLabz. All rights reserved.
/// </copyright>
/// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.SingletonPattern
{
    using System;

    /// <summary>
    ///  this class is totally thread safe which ensures double check locking
    ///  and creates only one instance of the class
    /// </summary>
    public sealed class DoubleCheckPattern
    {
        //// this is to check how many instances are being created
        private static int count = 0;

        //// initializing the instance which will be initialized later
        private static DoubleCheckPattern instance = null;

        //// The Object which acts as a locker for threads entering to create the instance
        private static Object Locker = new object();

        /// <summary>
        /// this method contains the logic to filter the threads Entering to create the new instance
        /// with double checking it increases the Performance as well
        /// </summary>
        public static DoubleCheckPattern Instance
        {
            get
            {
                //// here it is the first checking for thread entry
                if (instance == null)
                {
                    //// here the second entry if the 1st checking is cleared 
                    //// and this stage is responsible for the decrease in Performance
                    lock (Locker)
                    {
                        if (instance == null)
                        {
                            instance = new DoubleCheckPattern();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
