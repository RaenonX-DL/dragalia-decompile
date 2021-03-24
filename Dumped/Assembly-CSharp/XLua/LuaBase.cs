/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	public abstract class LuaBase : IDisposable
	{
		// Fields
		protected bool disposed;
		protected int luaReference;
		protected LuaEnv luaEnv;
	
		// Constructors
		public LuaBase(int reference, LuaEnv luaenv);
	
		// Methods
		~LuaBase();
		public void Dispose();
		public virtual void Dispose(bool disposeManagedResources);
		public override bool Equals(object o);
		public override int GetHashCode();
		internal virtual void push(IntPtr L);
	}
}
