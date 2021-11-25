using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using XLua.LuaDLL;

namespace XLua
{
	public class LuaEnv : IDisposable
	{
		internal struct GCAction
		{
			public int Reference;

			public bool IsDelegate;
		}

		public delegate byte[] CustomLoader(ref string filepath);

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

		internal IntPtr L => default(IntPtr);

		public LuaTable Global => null;

		public int GcPause
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int GcStepmul
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int Memroy => default(int);

		public static void AddIniter(Action<LuaEnv, ObjectTranslator> initer)
		{
		}

		public T LoadString<T>(byte[] chunk, string chunkName = "chunk", [Optional] LuaTable env)
		{
			return (T)null;
		}

		public T LoadString<T>(string chunk, string chunkName = "chunk", [Optional] LuaTable env)
		{
			return (T)null;
		}

		public LuaFunction LoadString(string chunk, string chunkName = "chunk", [Optional] LuaTable env)
		{
			return null;
		}

		public object[] DoString(byte[] chunk, string chunkName = "chunk", [Optional] LuaTable env)
		{
			return null;
		}

		public object[] DoString(string chunk, string chunkName = "chunk", [Optional] LuaTable env)
		{
			return null;
		}

		private void AddSearcher(lua_CSFunction searcher, int index)
		{
		}

		public void Alias(Type type, string alias)
		{
		}

		private static bool ObjectValidCheck(object obj)
		{
			return default(bool);
		}

		public void Tick()
		{
		}

		public void GC()
		{
		}

		public LuaTable NewTable()
		{
			return null;
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool dispose)
		{
		}

		public void ThrowExceptionFromError(int oldTop)
		{
		}

		internal void equeueGCAction(GCAction action)
		{
		}

		public void AddLoader(CustomLoader loader)
		{
		}

		public void AddBuildin(string name, lua_CSFunction initer)
		{
		}

		public void FullGc()
		{
		}

		public void StopGc()
		{
		}

		public void RestartGc()
		{
		}

		public bool GcStep(int data)
		{
			return default(bool);
		}
	}
}
