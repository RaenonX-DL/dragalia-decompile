﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using NUnit.Framework.Interfaces;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework
{
	[Serializable]
	public abstract class ResultStateException : Exception
	{
		// Properties
		public abstract ResultState ResultState { get; }
	
		// Constructors
		public ResultStateException(string message);
		protected ResultStateException(SerializationInfo info, StreamingContext context);
	}
}
