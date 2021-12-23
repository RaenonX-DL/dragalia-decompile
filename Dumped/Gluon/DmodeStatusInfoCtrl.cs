using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeStatusInfoCtrl : AnimationUIObject
	{
		[SerializeField]
		[Header("BG")]
		private Image bg2DImage;

		[SerializeField]
		[Header("Chara")]
		private Image charaBg;

		[SerializeField]
		public OutGameBgChara bgCharacter;

		[SerializeField]
		private RectTransform etoeCharaMoveNode;

		[SerializeField]
		private Transform charaOffsetNode;

		[SerializeField]
		private float charaMoveOffsetIPhoneX;

		[SerializeField]
		[Header("Talk")]
		private Button charaTalkButton;

		[SerializeField]
		[Header("TalkWindowModule")]
		public EventTalkWindowModule talkWindowModule;

		[SerializeField]
		[Header("Masks")]
		private RectMask2D questTopMask;

		[SerializeField]
		private RectMask2D questListMask;

		[SerializeField]
		private GameObject goSeperatorTop;

		[SerializeField]
		[Header("Old Publishers")]
		private AnimationUIGroup animationGroup;

		[SerializeField]
		private AnimationUIMove charaMove;

		[SerializeField]
		[Header("Howto")]
		private Button howtoButton;

		[SerializeField]
		[Header("Point")]
		private Text[] dmodePointText;

		[SerializeField]
		private Image[] dmodePointIcons;

		[SerializeField]
		private RectTransform dPointTrans;

		[SerializeField]
		private RectTransform howToTrans;

		private bool isFadeIn;

		private bool isNeedHeaderMargin;

		private Coroutine talkCoroutine;

		private const float topKeepStableHighPosOffset = -76f;

		private const float image2DHeightIPhoneX = 642f;

		public bool isInited
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsFadeIn
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		public void UpdateStatusInfoCtrl()
		{
		}

		public void ResetTopImageAndTalk()
		{
		}

		public static Vector2 LoadCharaterImage(int eventId, OutGameBgChara bgCharacter, Image charaBg, out Vector2 charaEventListPageMoveOffset, bool deactiveParts = false, [Optional] EventQuestTalkDataModel.TalkSet usingTalkSet)
		{
			return default(Vector2);
		}

		public void ResetCharaTalkButton(bool defaultValue = true)
		{
		}

		private void Load2DIBgImage()
		{
		}

		public void OnCharaTouched()
		{
		}

		public void StartTalk(string voiceData)
		{
		}

		public void StopTalk(bool forceFadeOut = false)
		{
		}

		private IEnumerator Talk(string voiceData)
		{
			return null;
		}

		public string UpdateVoiceData()
		{
			return null;
		}

		private string GetVoiceGroupName(string soundName)
		{
			return null;
		}

		public string GetVoiceData(bool isFromCharaTouch)
		{
			return null;
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		private IEnumerator FadeBackground(bool isFadeIn)
		{
			return null;
		}

		public void OnHowtoButtonTouched()
		{
		}
	}
}
