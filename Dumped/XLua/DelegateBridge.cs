using System;
using Gluon.Shooting;

namespace XLua
{
	public class DelegateBridge : DelegateBridgeBase
	{
		internal static DelegateBridge[] DelegateBridgeList;

		public static bool Gen_Flag;

		public void __Gen_Delegate_Imp0(int p0)
		{
		}

		public void __Gen_Delegate_Imp1(Enemy p0, EnemyManager.TemplateType p1, int p2)
		{
		}

		static DelegateBridge()
		{
		}

		public override Delegate GetDelegateByType(Type type)
		{
			return null;
		}

		public DelegateBridge(int reference, LuaEnv luaenv)
		{
		}

		public void PCall(IntPtr L, int nArgs, int nResults, int errFunc)
		{
		}

		public void Action()
		{
		}

		public void Action<T1>(T1 p1)
		{
		}

		public void Action<T1, T2>(T1 p1, T2 p2)
		{
		}

		public void Action<T1, T2, T3>(T1 p1, T2 p2, T3 p3)
		{
		}

		public void Action<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4)
		{
		}

		public TResult Func<TResult>()
		{
			return (TResult)null;
		}

		public TResult Func<TResult, T1>(T1 p1)
		{
			return (TResult)null;
		}

		public TResult Func<TResult, T1, T2>(T1 p1, T2 p2)
		{
			return (TResult)null;
		}

		public TResult Func<TResult, T1, T2, T3>(T1 p1, T2 p2, T3 p3)
		{
			return (TResult)null;
		}

		public TResult Func<TResult, T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4)
		{
			return (TResult)null;
		}
	}
}
