using System;
using System.Collections.Generic;
using System.Reflection;

namespace Gluon
{
	public class StoryScriptRuntime
	{
		private struct IfStack
		{
			public bool done;

			public bool processing;
		}

		private class CommandStack
		{
			public StoryScriptRuntime script;

			public StoryFunction function;

			public Dictionary<string, string> variables;

			public int index;

			public Stack<IfStack> ifStack;

			public string GetVariable(string value)
			{
				return null;
			}

			private string GetUnitVariable(string value)
			{
				return null;
			}
		}

		private List<StoryFunction> functions;

		private Dictionary<string, string> variables;

		private Stack<CommandStack> commandStack;

		private IStoryCommand currentCommand;

		private Queue<string> functionQueue;

		private bool executingFunction;

		private HashSet<string> resourceSet;

		public StoryScriptRuntime(StoryScript script, BaseScript baseScript)
		{
		}

		public string GetVariable(string value)
		{
			return null;
		}

		public string[] CollectResourceNames()
		{
			return null;
		}

		public void CallFunction(string functionName)
		{
		}

		private void CallFunctionImpl(string functionName)
		{
		}

		public void CallResourceFunction(string functionName)
		{
		}

		public bool ExecuteFunction(bool dryRun = false)
		{
			return default(bool);
		}

		private void OnException(Exception e)
		{
		}

		private bool ExecuteFunctionImpl(bool dryRun)
		{
			return default(bool);
		}

		private void ExecuteResourceFunction(int stackCount = 0)
		{
		}

		private IStoryCommand ExecuteCommand(StoryCommand command, StoryCommandCache.CommandCache commandCache, out object returnedObject, bool dryRun = false)
		{
			return null;
		}

		private static bool IsParams(ParameterInfo param)
		{
			return default(bool);
		}
	}
}
