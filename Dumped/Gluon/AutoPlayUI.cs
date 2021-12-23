using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Gluon
{
	public class AutoPlayUI : MonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private RectTransform rootRt;

		[SerializeField]
		private RectTransform autoButtonRt;

		[SerializeField]
		private RectTransform autoOffRt;

		[SerializeField]
		private RectTransform autoOnRt;

		[SerializeField]
		private RectTransform autoStopRt;

		[SerializeField]
		private RectTransform dragonButtonRt;

		[SerializeField]
		private RectTransform dragonOffRt;

		[SerializeField]
		private RectTransform dragonOnRt;

		[SerializeField]
		private RectTransform speedButtonRt;

		[SerializeField]
		private RectTransform speedNormalRt;

		[SerializeField]
		private RectTransform speedFastRt;

		[SerializeField]
		private RectTransform repeatButtonRt;

		[SerializeField]
		private RectTransform repeatOffRt;

		[SerializeField]
		private RectTransform repeatOnRt;

		[SerializeField]
		private RectTransform impossibleAutoRt;

		[SerializeField]
		private RectTransform impossibleDragonRt;

		[SerializeField]
		private RectTransform impossibleRepeatRt;

		[SerializeField]
		private SpriteRenderer imageOn;

		[SerializeField]
		private SpriteRenderer imageOnRing;

		[SerializeField]
		private SpriteRenderer imageOnAdd;

		[SerializeField]
		private SpriteRenderer imageStop;

		[SerializeField]
		private SpriteRenderer imageStopAdd;

		[SerializeField]
		private SpriteRenderer imageDragonOn;

		[SerializeField]
		private SpriteRenderer imageDragonOnRing;

		[SerializeField]
		private SpriteRenderer imageDragonOnAdd;

		[SerializeField]
		private SpriteRenderer imageSpeedFast;

		[SerializeField]
		private SpriteRenderer imageSpeedFastRing;

		[SerializeField]
		private SpriteRenderer imageRepeatOn;

		[SerializeField]
		private SpriteRenderer imageRepeatOnRing;

		[SerializeField]
		private SpriteRenderer imageLockAuto;

		[SerializeField]
		private SpriteRenderer imageLockSpeed;

		[SerializeField]
		private SpriteRenderer imageLockRepeat;

		[SerializeField]
		private Text textRepeatOff;

		[SerializeField]
		private Text textRepeatOn;

		[SerializeField]
		[Header("resource")]
		[Tooltip("å\u0080\u008dé\u0080\u009fã\u0082¢ã\u0082¤ã\u0082³ã\u0083³")]
		private Sprite[] speedIcon;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0083ªã\u0083³ã\u0082°ã\u0081®å\u009b\u009eè»¢é\u0080\u009fåº¦")]
		private float ringRotateSpeed;

		[SerializeField]
		[Tooltip("raycastç\u0094\u00a8ã\u0081®ã\u0083\u0087ã\u0083\u0095ã\u0082©ã\u0083«ã\u0083\u0088ã\u0082½ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0083³ã\u0082°ã\u0082ªã\u0083¼ã\u0083\u0080ã\u0083¼ï¼\u0088UseRaycastCanvasã\u0081®ã\u0082½ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0083³ã\u0082°ã\u0082ªã\u0083¼ã\u0083\u0080ã\u0083¼ä»¥ä\u00b8\u008aï¼\u0089")]
		private int defaultRaycastSortingOrder;

		[SerializeField]
		[Tooltip("ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088ã\u0081®ã\u0082½ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0083³ã\u0082°ã\u0082ªã\u0083¼ã\u0083\u0080ã\u0083¼ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		private int textSortingOrderOffset;

		[SerializeField]
		[Tooltip("ã\u0083¬ã\u0082¤ã\u0083\u0089ã\u0082\u00afã\u0082\u00a8ã\u0082¹ã\u0083\u0088ã\u0081®Yåº§æ\u00a8\u0099ã\u0083ªã\u0082¹ã\u0083\u0088")]
		private float[] raidQuestAdjustPosYList;

		[SerializeField]
		[Tooltip("ã\u0083\u0088ã\u0083¼ã\u0082¿ã\u0083«ã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8é\u009b\u0086è\u00a8\u0088ã\u0082\u00afã\u0082\u00a8ã\u0082¹ã\u0083\u0088ã\u0081®Yåº§æ\u00a8\u0099")]
		private float sumUpTotalDamageQuestAdjustPosY;

		[SerializeField]
		[Tooltip("Dã\u0083¢ã\u0083¼ã\u0083\u0089ã\u0081®Yåº§æ\u00a8\u0099")]
		private float dmodeAdjustPosY;

		private Sequence sequenceToStop;

		private Sequence sequenceIdleAlpha;

		private SortingGroup spriteSortingGroup;

		private Canvas repeatOffTextCanvas;

		private Canvas repeatOnTextCanvas;

		private Canvas _raycastCanvas;

		private Vector3 basePos;

		private Vector3 ringRot;

		private float tweenStopImageAlpha;

		private float tweenIdleAlpha;

		private bool isStopAutoPlay;

		private bool isAutoEnable;

		private bool isRepeatEnable;

		private bool isQuestStartShowing;

		private const float toStopFadeDuration = 0.1f;

		private const float idleAlphaDuration = 0.75f;

		private const float idleAlphaScale = 0.5f;

		private const float idleAlphaScaleStop = 0.15f;

		private const float lockStatusAdjustPos = 20f;

		private const float systemMessageDisplayTime = 2f;

		public static AutoPlayUI Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize()
		{
		}

		private void ResetParameter()
		{
		}

		private void UpdateStopAlphaValue(float alpha)
		{
		}

		private void UpdateIdleAlphaValue(float alpha)
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void UpdateImageFade(ref SpriteRenderer sprite, float a)
		{
		}

		public void OnClickAutoPlay()
		{
		}

		private void ExecOnClickAutoPlay(bool val, bool withSE)
		{
		}

		public void OnClickDragon()
		{
		}

		public void OnClickSpeed()
		{
		}

		public void OnClickRepeat()
		{
		}

		private void SetAutoMode(bool val, bool withSE)
		{
		}

		private void SetDragonImage(bool val, bool withSE, bool applyMode)
		{
		}

		private void SetSpeedRateImage(InGameTime.GameSpeed rate, bool withSE)
		{
		}

		private void SetRepeatImage(bool val, bool effect)
		{
		}

		public void SetLock(bool isLock)
		{
		}

		public void SetEnable(bool isEnable)
		{
		}

		public void SetRepeatCounter(int currNum, int loopNum)
		{
		}

		public void SetRaidQuestPosition(int otherPlayerNum)
		{
		}

		public void SetSumUpTotalDamageQuestPosition()
		{
		}

		public void SetDmodePosition()
		{
		}

		private void SetActive(ref RectTransform rt, bool active)
		{
		}

		private void SetActive(ref SpriteRenderer sr, bool active)
		{
		}

		private bool IsSingleQuest()
		{
			return default(bool);
		}

		private bool IsEnableRepeat()
		{
			return default(bool);
		}
	}
}
