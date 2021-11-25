using System;
using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class LoginBonusPageCharacter : LoginBonusPageBase
	{
		private int rewardIndex;

		protected override void Start()
		{
		}

		public override void OnNextLoginBonus()
		{
		}

		protected override Vector2[] GetIconPositionArray(int total)
		{
			return null;
		}

		private IEnumerator EnableTapCoroutine()
		{
			return null;
		}

		private IEnumerator ExecDemoCoroutine(Action endCallback)
		{
			return null;
		}

		public override void OnScreenTapped()
		{
		}
	}
}
