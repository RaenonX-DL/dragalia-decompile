/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using XLua;
using XLua.LuaDLL;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua.TemplateEngine
{
	public class LuaTemplate
	{
		// Fields
		private static lua_CSFunction templateCompileFunction;
		private static lua_CSFunction templateExecuteFunction;
	
		// Constructors
		public LuaTemplate();
		static LuaTemplate();
	
		// Methods
		public static string ComposeCode(List<Chunk> chunks);
		public static LuaFunction Compile(LuaEnv luaenv, string snippet);
		public static string Execute(LuaFunction compiledTemplate, LuaTable parameters);
		public static string Execute(LuaFunction compiledTemplate);
		[MonoPInvokeCallback]
		public static int Compile(IntPtr L);
		[MonoPInvokeCallback]
		public static int Execute(IntPtr L);
		public static void OpenLib(IntPtr L);
	}
}
