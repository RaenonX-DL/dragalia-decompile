using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QRBuildEventBonusCell : SimpleAnimationCell
	{
		[SerializeField]
		private Text infoText;

		[SerializeField]
		private Text valueText;

		[SerializeField]
		private Image effectImage;

		[SerializeField]
		private Transform flashPosTransform;

		[SerializeField]
		private GameObject notClearImage;

		public Action checkLabelAction;

		private FlashPlayer flashPlayer;

		private bool isCancelled;

		private Action onCheckDone;

		private const float moveBackDis = 20f;

		public float pointValue
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isMissionCleared
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected override void Awake()
		{
		}

		public void SetContent(string info, float value, bool isStageClear)
		{
		}

		public void ShowStartAnimation(FlashPlayerManager flashPlayerManager, Action onCheckDone)
		{
		}

		public void ShowBlinkAnimation()
		{
		}

		private void ShowFlashAnimation(FlashPlayerManager flashPlayerManager, Action onCheckDone)
		{
		}

		private void CreateFlash(FlashPlayerManager flashPlayerManager)
		{
		}

		public void CancelAnimation(FlashPlayerManager flashPlayerManager)
		{
		}

		private void CancelAnimationImpl(FlashPlayerManager flashPlayerManager)
		{
		}
	}
}
