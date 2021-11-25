using System;
using System.Collections.Generic;
using XLua.LuaDLL;

namespace XLua.TemplateEngine
{
	public class LuaTemplate
	{
		private static lua_CSFunction templateCompileFunction;

		private static lua_CSFunction templateExecuteFunction;

		public static string ComposeCode(List<Chunk> chunks)
		{
			return null;
		}

		public static LuaFunction Compile(LuaEnv luaenv, string snippet)
		{
			return null;
		}

		public static string Execute(LuaFunction compiledTemplate, LuaTable parameters)
		{
			return null;
		}

		public static string Execute(LuaFunction compiledTemplate)
		{
			return null;
		}

		public static int Compile(IntPtr L)
		{
			return default(int);
		}

		public static int Execute(IntPtr L)
		{
			return default(int);
		}

		public static void OpenLib(IntPtr L)
		{
		}
	}
}
