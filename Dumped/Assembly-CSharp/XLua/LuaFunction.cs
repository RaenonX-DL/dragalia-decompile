/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	public class LuaFunction : LuaBase
	{
		// Constructors
		public LuaFunction(int reference, LuaEnv luaenv);
	
		// Methods
		public void Action<T>(T a);
		public TResult Func<T, TResult>(T a);
		public void Action<T1, T2>(T1 a1, T2 a2);
		public TResult Func<T1, T2, TResult>(T1 a1, T2 a2);
		public object[] Call(object[] args, Type[] returnTypes);
		public object[] Call(params object[] args);
		public T Cast<T>();
		public void SetEnv(LuaTable env);
		internal override void push(IntPtr L);
		public override string ToString();
	}
}
