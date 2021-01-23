/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Shooting;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	public class DelegateBridge : DelegateBridgeBase
	{
		// Fields
		internal static DelegateBridge[] DelegateBridgeList;
		public static bool Gen_Flag;
	
		// Constructors
		static DelegateBridge();
		public DelegateBridge(int reference, LuaEnv luaenv);
	
		// Methods
		public void __Gen_Delegate_Imp0(int p0);
		public void __Gen_Delegate_Imp1(Enemy p0, EnemyManager.TemplateType p1, int p2);
		public override Delegate GetDelegateByType(Type type);
		public void PCall(IntPtr L, int nArgs, int nResults, int errFunc);
		public void Action();
		public void Action<T1>(T1 p1);
		public void Action<T1, T2>(T1 p1, T2 p2);
		public void Action<T1, T2, T3>(T1 p1, T2 p2, T3 p3);
		public void Action<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4);
		public TResult Func<TResult>();
		public TResult Func<T1, TResult>(T1 p1);
		public TResult Func<T1, T2, TResult>(T1 p1, T2 p2);
		public TResult Func<T1, T2, T3, TResult>(T1 p1, T2 p2, T3 p3);
		public TResult Func<T1, T2, T3, T4, TResult>(T1 p1, T2 p2, T3 p3, T4 p4);
	}
}
