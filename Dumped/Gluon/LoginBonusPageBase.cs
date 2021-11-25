using System;
using System.Collections;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public abstract class LoginBonusPageBase : PageBase
	{
		protected enum DemoKind
		{
			Today,
			DailyGift,
			Tomorrow,
			Nof
		}

		[SerializeField]
		protected Canvas uiCanvasFront;

		[SerializeField]
		protected Canvas uiCanvasMiddle;

		[SerializeField]
		protected Canvas uiCanvasBack;

		[SerializeField]
		private GameObject bonusItemIconTemplate;

		[SerializeField]
		private GameObject tapToNextItem;

		[SerializeField]
		private PointerEventHandler screenTapPointerEventHandler;

		[SerializeField]
		protected RawImage bgImage;

		private const string localizedBGPathTemplate = "Images/OutGame/LoginBonus/Background/Localized/EventLoginBonus_{0:D4}";

		protected LoginBonusScene scene;

		protected List<LoginBonusRewardElement> rewardList;

		protected List<GameObject> itemIcons;

		protected int getDayIndex;

		protected int nextDayIndex;

		protected int totalDays;

		protected Coroutine execDemoCoroutine;

		protected bool isSkipButtonPushed;

		private bool isScreenTapped;

		protected bool isEnableScreenTapped;

		protected static readonly Vector2 iconPositionConvertScale;

		public override void OnPageBecomeActive(object data)
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Reset()
		{
		}

		protected void InitCamera()
		{
		}

		protected void SetupBG()
		{
		}

		public abstract void OnNextLoginBonus();

		protected static List<LoginBonusRewardElement> CreateRewardList(int loginBonusId)
		{
			return null;
		}

		protected void SetupContents()
		{
		}

		public void TeardownContents()
		{
		}

		protected virtual void ResetDemo()
		{
		}

		protected virtual void ProcOnDemoEnd()
		{
		}

		protected virtual Vector2 GetIconPosition(int day, int total)
		{
			return default(Vector2);
		}

		protected abstract Vector2[] GetIconPositionArray(int total);

		protected static void replaceFlashPlayerPlaneImage(FlashPlayer player, List<KeyValuePair<string, Material>> planeNameAndReplaceMaterialPairs)
		{
		}

		protected IEnumerator SkipDemoCoroutine(Action endCallback)
		{
			return null;
		}

		protected void StopExecDemoCoroutine()
		{
		}

		public virtual void OnScreenTapped()
		{
		}

		protected void SetEnableTapped(bool enable)
		{
		}

		protected bool IsScreenTapped()
		{
			return default(bool);
		}

		protected IEnumerator WaitScreenTapped()
		{
			return null;
		}

		protected IEnumerator WaitForSecondsOrScreenTapped(float second)
		{
			return null;
		}

		protected IEnumerator WaitUntilOrScreenTapped(Func<bool> func)
		{
			return null;
		}

		protected void EnableTapToNext(bool isEnable = true)
		{
		}

		protected void LoadNewEnrollmentPage(int id, GiftType giftType, Action onFinish)
		{
		}
	}
}
