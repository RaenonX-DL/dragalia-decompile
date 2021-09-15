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
	public class StoryScriptRuntime
	{
		// Fields
		private List<StoryFunction> functions;
		private Dictionary<string, string> variables;
		private Stack<CommandStack> commandStack;
		private IStoryCommand currentCommand;
		private Queue<string> functionQueue;
		private bool executingFunction;
		private HashSet<string> resourceSet;
	
		// Nested types
		private struct IfStack
		{
			// Fields
			public bool done;
			public bool processing;
		}
	
		private class CommandStack
		{
			// Fields
			public StoryScriptRuntime script;
			public StoryFunction function;
			public Dictionary<string, string> variables;
			public int index;
			public Stack<IfStack> ifStack;
	
			// Constructors
			public CommandStack();
	
			// Methods
			public string GetVariable(string value);
			private string GetUnitVariable(string value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public string functionName;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal bool _CallFunctionImpl_b__0(StoryFunction f);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public string functionName;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal bool _CallResourceFunction_b__0(StoryFunction f);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public StoryCommand command;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal bool _ExecuteFunctionImpl_b__0(StoryFunction f);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public StoryCommand command;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal bool _ExecuteResourceFunction_b__0(StoryFunction f);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public CommandStack stack;
			public Func<string, string> __9__0;
			public Func<string, string> __9__1;
			public Func<string, string> __9__2;
			public Func<string, string> __9__3;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal string _ExecuteCommand_b__0(string s);
			internal string _ExecuteCommand_b__1(string s);
			internal string _ExecuteCommand_b__2(string s);
			internal string _ExecuteCommand_b__3(string s);
		}
	
		// Constructors
		public StoryScriptRuntime(StoryScript script, BaseScript baseScript);
	
		// Methods
		public string GetVariable(string value);
		public string[] CollectResourceNames();
		public void CallFunction(string functionName);
		private void CallFunctionImpl(string functionName);
		public void CallResourceFunction(string functionName);
		public bool ExecuteFunction(bool dryRun = false);
		private void OnException(Exception e);
		private bool ExecuteFunctionImpl(bool dryRun);
		private void ExecuteResourceFunction(int stackCount = 0);
		private IStoryCommand ExecuteCommand(StoryCommand command, StoryCommandCache.CommandCache commandCache, out object returnedObject, bool dryRun = false);
		private static bool IsParams(ParameterInfo param);
	}
}
