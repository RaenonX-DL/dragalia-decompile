using System;
using System.Collections;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class LoginBonusPageMain : LoginBonusPageBase
	{
		[SerializeField]
		private Image boardImage;

		[SerializeField]
		[Header("Balloon")]
		public GameObject balloonPanelObject;

		public Text balloonPanelNameText;

		public Text balloonPanelCommentText;

		public AnimationUITalkWindow balloonAnimation;

		[SerializeField]
		[Header("GetItemIcon")]
		public GameObject getItemIconObject;

		public Animator getItemIconAnimator;

		[SerializeField]
		[Header("DailyItem")]
		public LoginBonusItemIcon dailyItem;

		[SerializeField]
		[Header("Title")]
		public Transform titleBoardNode;

		[SerializeField]
		[Header("SyncBalloon")]
		public KeepStableToTransform balloonKeepStable;

		[SerializeField]
		[Header("SkipTicketText")]
		public Text skipTicketDisposeText;

		[SerializeField]
		[Header("BonusImage")]
		public Image skipTicketBonusImage;

		private FlashPlayer getItemPlayer;

		private LoginBonusCharacterControl characterControl;

		private LoginBonusUnitShaderSettings unitShaderSettings;

		private const int dailyItemIndex = 100000;

		private int mouthMuteFrameCount;

		private const int mouthVoiceOverThreshold = 4;

		private bool firstTalkBallonOn;

		private const string currentLoginBonusVoiceName = "VO_CHR_100007_01_OUT_0201";

		private const string nextLoginBonusVoiceName = "VO_CHR_100007_01_OUT_0202";

		private const string commonItemLoginBonusVoiceName = "VO_CHR_100007_01_OUT_0206";

		private const string skipTicketLoginBonusVoiceName = "VO_CHR_100007_01_OUT_0207";

		private readonly string[] randomLeavingVoiceName;

		private const string boardImagePath = "Images/OutGame/LoginBonus/Image/Board_01_Login_Bonus_{0:00}";

		private const string skipBonusImagePath = "Images/OutGame/LoginBonus/Other/Localized/loginbonus_skipticket";

		private static readonly Vector2[] bonusIconPositions;

		protected override void Start()
		{
		}

		private IEnumerator LoadChara()
		{
			return null;
		}

		public void OnChangedBackgroundShaderParameter()
		{
		}

		private LoginBonusItemIcon GetIconByIndex(int demoIndex)
		{
			return null;
		}

		private void Update()
		{
		}

		private IEnumerator ExecDemoCoroutine(Action endCallback)
		{
			return null;
		}

		private void OpenBalloon(string nameText, string commentText)
		{
		}

		private void CloseBalloon()
		{
		}

		private void PlayGetItemFlash(LoginBonusRewardElement getElement, LoginBonusRewardElement nextElement)
		{
		}

		private void ReplaceFlashDailyImage()
		{
		}

		private void CloseGetItem()
		{
		}

		public void OnSkipButtonPressed()
		{
		}

		public override void OnNextLoginBonus()
		{
		}

		protected override void ResetDemo()
		{
		}

		protected override void ProcOnDemoEnd()
		{
		}

		protected override Vector2[] GetIconPositionArray(int total)
		{
			return null;
		}
	}
}
