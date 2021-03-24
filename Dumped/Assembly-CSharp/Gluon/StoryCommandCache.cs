/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class StoryCommandCache
	{
		// Fields
		private static Dictionary<string, CommandCache> commandMap;
		private static Dictionary<string, CommandCache> resourceCommandMap;
	
		// Nested types
		public class CommandCache
		{
			// Fields
			public Type type;
			public MethodInfo method;
			public ParameterInfo[] parameters;
	
			// Constructors
			public CommandCache();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public Type type;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal bool _.cctor_b__0(Type p);
		}
	
		// Constructors
		static StoryCommandCache();
	
		// Methods
		public static CommandCache GetCommand(string commandName);
		public static CommandCache GetResourceCommand(string commandName);
	}
}
