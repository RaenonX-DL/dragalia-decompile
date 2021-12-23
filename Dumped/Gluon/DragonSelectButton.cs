using System;
using UnityEngine;

namespace Gluon
{
	public class DragonSelectButton : DragonButton
	{
		protected bool _lastHasDragon;

		public static DragonSelectButton Create(GameObject parent, int index, Action<DragonSelectButton> onClick, bool isLeft)
		{
			return null;
		}

		protected void Initialize(Action<DragonSelectButton> onClick, bool isLeft)
		{
		}

		protected override void UpdateUI(bool isForce = false)
		{
		}

		private void CheckInactive(bool trigger, bool isMaxNow)
		{
		}

		public bool IsEnableTransform()
		{
			return default(bool);
		}
	}
}
