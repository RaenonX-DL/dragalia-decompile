using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlRayInput : FlInputBase
	{
		private FlUIBase _currentInputUI;

		private Ray _currentRay;

		public FlRayInput(FlUIManager uiManager, int inputIndex)
		{
		}

		protected override void _Update_Common_Start()
		{
		}

		protected override void _Update_Wait_Init()
		{
		}

		protected override void _Update_Wait_Loop()
		{
		}

		protected override void _Update_Select_Init()
		{
		}

		protected override void _Update_Select_Loop()
		{
		}

		protected override void _Update_Down_Init()
		{
		}

		protected override void _Update_Down_Loop()
		{
		}

		private void _UpdateSelection()
		{
		}

		public override FlInputDownTypes _GetDown(FlUIBase inputUI)
		{
			return default(FlInputDownTypes);
		}

		public override FlInputDownLoopTypes _GetDownLoop(FlUIBase inputUI)
		{
			return default(FlInputDownLoopTypes);
		}

		public override FlInputUpTypes _GetUp(FlUIBase inputUI)
		{
			return default(FlInputUpTypes);
		}
	}
}
