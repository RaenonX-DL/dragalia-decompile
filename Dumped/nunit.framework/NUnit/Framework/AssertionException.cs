/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using NUnit.Framework.Interfaces;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework
{
	[Serializable]
	public class AssertionException : ResultStateException
	{
		// Properties
		public override ResultState ResultState { get; }
	
		// Constructors
		public AssertionException(string message);
		protected AssertionException(SerializationInfo info, StreamingContext context);
	}
}
