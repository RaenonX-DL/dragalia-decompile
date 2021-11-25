using System;
using System.Collections;
using Cute.Cri;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class LoginBonusPageEvent : LoginBonusPageBase
	{
		[SerializeField]
		private Text PeriodText;

		[SerializeField]
		private Transform periodTextBase;

		[SerializeField]
		private Transform bonusPanelTransform;

		[SerializeField]
		private Transform frontCanvasFrameTransform;

		[SerializeField]
		private Button skipButton;

		private EffectObject effect;

		private const string paperEffectPath = "EFF_SCE_2D_CMN_106";

		private const string loginbonusSoundGroup = "LOGINBONUS";

		private const string paperSoundPath = "SE_LOGINBONUS_0008";

		private AudioPlayback paperSoundPlayback;

		private const string flashPathTemplate = "Prefabs/OutGame/LoginBonus/Flash/{0}";

		private const int yOffset = 115;

		private static readonly Vector2[][] bonusIconPositions;

		private void Init()
		{
		}

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageBecomeInActive()
		{
		}

		private void PlayEffect()
		{
		}

		private IEnumerator PlayPaperSE()
		{
			return null;
		}

		private void SetupPeriodText()
		{
		}

		private Vector2 ConvertPhotoshopPositionToLocalPosition(Vector2 pos)
		{
			return default(Vector2);
		}

		public void OnSkipButtonPressed()
		{
		}

		public override void OnNextLoginBonus()
		{
		}

		protected override void Reset()
		{
		}

		private bool ShouldInjectFlash(LoginBonusRewardElement elem)
		{
			return default(bool);
		}

		private IEnumerator ExecDemoCoroutine(Action endCallback)
		{
			return null;
		}

		private IEnumerator PlaySpecialFlashSE(string seName, float triggerTime)
		{
			return null;
		}

		protected override Vector2 GetIconPosition(int day, int total)
		{
			return default(Vector2);
		}

		protected override Vector2[] GetIconPositionArray(int total)
		{
			return null;
		}
	}
}
