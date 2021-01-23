/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using XLua.LuaDLL;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	public class LuaEnv : IDisposable
	{
		// Fields
		public const string CSHARP_NAMESPACE = "xlua_csharp_namespace";
		public const string MAIN_SHREAD = "xlua_main_thread";
		internal IntPtr rawL;
		private LuaTable _G;
		internal ObjectTranslator translator;
		internal int errorFuncRef;
		private const int LIB_VERSION_EXPECT = 105;
		private static List<Action<LuaEnv, ObjectTranslator>> initers;
		private int last_check_point;
		private int max_check_per_tick;
		private Func<object, bool> object_valid_checker;
		private bool disposed;
		private Queue<GCAction> refQueue;
		private string init_xlua;
		internal List<CustomLoader> customLoaders;
		internal Dictionary<string, lua_CSFunction> buildin_initer;
	
		// Properties
		internal IntPtr L { get; }
		public LuaTable Global { get; }
		public int GcPause { get; set; }
		public int GcStepmul { get; set; }
		public int Memroy { get; }
	
		// Nested types
		internal struct GCAction
		{
			// Fields
			public int Reference;
			public bool IsDelegate;
		}
	
		public delegate byte[] CustomLoader(ref string filepath);
	
		// Constructors
		public LuaEnv();
		static LuaEnv();
	
		// Methods
		public static void AddIniter(Action<LuaEnv, ObjectTranslator> initer);
		public T LoadString<T>(byte[] chunk, string chunkName = "chunk", LuaTable env = null);
		public T LoadString<T>(string chunk, string chunkName = "chunk", LuaTable env = null);
		public LuaFunction LoadString(string chunk, string chunkName = "chunk", LuaTable env = null);
		public object[] DoString(byte[] chunk, string chunkName = "chunk", LuaTable env = null);
		public object[] DoString(string chunk, string chunkName = "chunk", LuaTable env = null);
		private void AddSearcher(lua_CSFunction searcher, int index);
		public void Alias(Type type, string alias);
		private static bool ObjectValidCheck(object obj);
		public void Tick();
		public void GC();
		public LuaTable NewTable();
		public void Dispose();
		public virtual void Dispose(bool dispose);
		public void ThrowExceptionFromError(int oldTop);
		internal void equeueGCAction(GCAction action);
		public void AddLoader(CustomLoader loader);
		public void AddBuildin(string name, lua_CSFunction initer);
		public void FullGc();
		public void StopGc();
		public void RestartGc();
		public bool GcStep(int data);
	}
}
