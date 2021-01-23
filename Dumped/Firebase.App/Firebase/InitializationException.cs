/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 41: Firebase.App.dll - Assembly: Firebase.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase
{
	public sealed class InitializationException : Exception
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable]
		private InitResult _InitResult_k__BackingField;
	
		// Properties
		public InitResult InitResult { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public InitializationException(InitResult result, string message);
		public InitializationException(InitResult result, string message, Exception inner);
	}
}
