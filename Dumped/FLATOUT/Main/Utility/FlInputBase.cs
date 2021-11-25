using System.Collections.Generic;

namespace FLATOUT.Main.Utility
{
	public class FlInputBase
	{
		public enum BaseStateTypes
		{
			Wait_Init,
			Wait_Loop,
			Down_Init,
			Down_Loop,
			Select_Init,
			Select_Loop
		}

		protected BaseStateTypes _currentState;

		protected FlUIManager _uiManager;

		protected bool _enable;

		protected bool _prevEnable;

		protected int _inputIndex;

		protected float _currentDownLoopTime;

		protected float _currentSelectTime;

		protected List<FlObjectBase> _hitObjectList;

		protected List<FlUIBase> _hitInputUIList;

		public bool Enable => default(bool);

		public int InputIndex => default(int);

		public FlInputBase(FlUIManager uiManager, int inputIndex)
		{
		}

		public virtual void _Reset()
		{
		}

		public virtual void _Update()
		{
		}

		protected virtual void _Update_Common_Start()
		{
		}

		protected virtual void _Update_Common_End()
		{
		}

		protected virtual void _Update_Wait_Init()
		{
		}

		protected virtual void _Update_Wait_Loop()
		{
		}

		protected virtual void _Update_Down_Init()
		{
		}

		protected virtual void _Update_Down_Loop()
		{
		}

		protected virtual void _Update_Select_Init()
		{
		}

		protected virtual void _Update_Select_Loop()
		{
		}

		public virtual void _SetEnable(bool enable)
		{
		}

		public virtual FlInputDownTypes _GetDown(FlUIBase inputUI)
		{
			return default(FlInputDownTypes);
		}

		public virtual FlInputDownLoopTypes _GetDownLoop(FlUIBase inputUI)
		{
			return default(FlInputDownLoopTypes);
		}

		public virtual FlInputUpTypes _GetUp(FlUIBase inputUI)
		{
			return default(FlInputUpTypes);
		}
	}
}
