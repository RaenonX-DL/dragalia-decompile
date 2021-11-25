using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QREventCharaResult : QREventResultBase
	{
		public enum EventCharaResultState
		{
			Undefined,
			Start,
			End,
			MaxStart,
			MaxWait,
			MaxEnd
		}

		private static readonly string seOpenHeart;

		private static readonly string seMoveHeart;

		private static readonly string seBigHeart;

		private static readonly string seMax;

		private static readonly string effNormalBg;

		private static readonly string effNormalFrontHeart;

		private static readonly string effMaxBg;

		private static readonly string effMaxFrontHeart;

		private EffectObject normalBgEffect;

		private EffectObject normalFrontEffect;

		private EffectObject maxBgEffect;

		private EffectObject maxFrontEffect;

		[SerializeField]
		private PointerEventHandler skipButtonEventHandler;

		[SerializeField]
		private Image charaBg;

		[SerializeField]
		private Image fadeBg;

		[SerializeField]
		private OutGameBgChara bgCharacter;

		[SerializeField]
		private Transform bgCharaOffset;

		[SerializeField]
		private Text intimacyText;

		[SerializeField]
		private Text gotIntimacyText;

		[SerializeField]
		private Gauge gauge;

		[SerializeField]
		private float pointCountUpDuration;

		[SerializeField]
		private float bgEffectPosY;

		[SerializeField]
		private Vector3 bgEffectScale;

		[SerializeField]
		private Transform heartAnimationParent;

		[SerializeField]
		private Text charaNameText;

		[SerializeField]
		private Text charaTalk;

		[SerializeField]
		private float contentAnimationSpeed;

		private FlashPlayer heartFlashPlayer;

		private FlashPlayer gaugeEffectflashPlayer;

		private FlashPlayer glitterBurstflashPlayer;

		private QuestResultModel resultModel;

		private Sequence seq;

		private EventKindType eventType;

		private EventQuestTalkDataModel.TalkSet talkSet;

		private int eventGroupId;

		private int previousPoint;

		private bool isMax;

		private const float maxEffectWaitTime = 0.6f;

		private Tweener talkTweener;

		private bool blockTouchUntilStateChanged;

		private EventCharaResultState _state;

		[SerializeField]
		private int textAnimationDigits;

		private const float waitForNormalAnimation = 0.33333334f;

		private EventCharaResultState state
		{
			get
			{
				return default(EventCharaResultState);
			}
			set
			{
			}
		}

		public static void LoadEffect()
		{
		}

		public static void ReleaseEffect()
		{
		}

		public void SetContent(QuestResultTopPage resultTop, QuestResultModel model)
		{
		}

		protected override void Start()
		{
		}

		private void SetBackKey(UnityAction action)
		{
		}

		private IEnumerator PlayNormalAnimation()
		{
			return null;
		}

		private IEnumerator PlayMaxAnimation()
		{
			return null;
		}

		private IEnumerator MaxEffectWait()
		{
			return null;
		}

		private void ShowNoteAnimation()
		{
		}

		private Sequence UpdateGauge(Action endCallback, bool needAnimation = true)
		{
			return null;
		}

		private void SetGauge(float startValue, float endValue)
		{
		}

		public void OnScreenTouched()
		{
		}

		private void RunMaxExitAnimation()
		{
		}

		private void RunNormalExitAnimation()
		{
		}

		private void OnModuleEnd()
		{
		}

		private Tweener Talk(Action completeCallback)
		{
			return null;
		}

		private Tweener Talk(bool useMaxText = false)
		{
			return null;
		}
	}
}
