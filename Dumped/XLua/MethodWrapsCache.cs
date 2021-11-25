using System;
using System.Collections.Generic;
using System.Reflection;
using XLua.LuaDLL;

namespace XLua
{
	public class MethodWrapsCache
	{
		private ObjectTranslator translator;

		private ObjectCheckers objCheckers;

		private ObjectCasters objCasters;

		private Dictionary<Type, lua_CSFunction> constructorCache;

		private Dictionary<Type, Dictionary<string, lua_CSFunction>> methodsCache;

		private Dictionary<Type, lua_CSFunction> delegateCache;

		public MethodWrapsCache(ObjectTranslator translator, ObjectCheckers objCheckers, ObjectCasters objCasters)
		{
		}

		public lua_CSFunction GetConstructorWrap(Type type)
		{
			return null;
		}

		public lua_CSFunction GetMethodWrap(Type type, string methodName)
		{
			return null;
		}

		public lua_CSFunction GetMethodWrapInCache(Type type, string methodName)
		{
			return null;
		}

		public lua_CSFunction GetDelegateWrap(Type type)
		{
			return null;
		}

		public lua_CSFunction GetEventWrap(Type type, string eventName)
		{
			return null;
		}

		public MethodWrap _GenMethodWrap(Type type, string methodName, IEnumerable<MemberInfo> methodBases, bool forceCheck = false)
		{
			return null;
		}

		private static bool tryMakeGenericMethod(ref MethodBase method)
		{
			return default(bool);
		}
	}
}
