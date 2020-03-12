﻿// <copyright file="PersonShallowCopy.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.PrototypeDesignPattern
{
    using System;

    /// <summary>
    /// this class simulates the example for shallow cloning where change in clone effects the original copy
    /// </summary>
    public class PersonShallowCopy : ICloneable
    {