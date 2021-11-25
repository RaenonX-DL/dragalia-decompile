using System;
using System.Collections.Generic;
using System.Reflection;

namespace Gluon
{
	public static class StoryCommandCache
	{
		public class CommandCache
		{
			public Type type;

			public MethodInfo method;

			public ParameterInfo[] parameters;
		}

		private static Dictionary<string, CommandCache> commandMap;

		private static Dictionary<string, CommandCache> resourceCommandMap;

		static StoryCommandCache()
		{
		}

		public static CommandCache GetCommand(string commandName)
		{
			return null;
		}

		public static CommandCache GetResourceCommand(string commandName)
		{
			return null;
		}
	}
}
