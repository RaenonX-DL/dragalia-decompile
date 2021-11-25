using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InGamePartyButtonUI : FastUpdateMonoBehaviour
	{
		public delegate void ButtonDelegate(CharacterBase chara, int index);

		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform rootRt;

		[SerializeField]
		[Tooltip("å¾©æ\u00b4»ç\u0094\u00a8ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform rebornRootRt;

		[SerializeField]
		[Tooltip("å¾©æ\u00b4»ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform rebornIconRt;

		[SerializeField]
		[Tooltip("ç\u0084¡å\u0088¶é\u0099\u0090å¾©æ\u00b4»ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform unlimitRebornIconRt;

		[SerializeField]
		[Tooltip("å¾©æ\u00b4»æ\u0099\u0082é\u0096\u0093ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform rebornTimeRt;

		[SerializeField]
		private Button button;

		[SerializeField]
		private ElementIconUISpriteRenderer element;

		[SerializeField]
		private InGameGaugeUISpriteRenderer hpGauge;

		[SerializeField]
		private InGameGaugeUISpriteRenderer timeGauge;

		[SerializeField]
		private InGameGaugeUISpriteRenderer shieldGauge;

		[SerializeField]
		private SpriteRenderer playerNoImage;

		[SerializeField]
		private SpriteRenderer frameImage;

		[SerializeField]
		private PlayerBuffUI playerBuffUI;

		[SerializeField]
		private SpriteRenderer faceImage;

		[SerializeField]
		private SpriteRenderer monoFaceImage;

		[SerializeField]
		[Tooltip("å¾©æ\u00b4»æ\u0099\u0082é\u0096\u0093ç\u0094»å\u0083\u008f")]
		private SpriteRenderer rebornTimeImage;

		[SerializeField]
		[Header("resource")]
		private Sprite[] playerNoIcon;

		[SerializeField]
		[Tooltip("æ\u0095°å­\u0097ç\u0094»å\u0083\u008f")]
		private Sprite[] numberSprites;

		[SerializeField]
		private Material colorAdjustMaterial;

		[SerializeField]
		[Header("parameter")]
		private float dispBuffSec;

		[SerializeField]
		private float monochromeSaturation;

		[SerializeField]
		private float monochromeBrightness;

		[SerializeField]
		[Tooltip("å¾©æ\u00b4»ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0081®é\u0085\u008dç½®é\u0096\u0093é\u009a\u0094")]
		private float rebornIconMerginX;

		private bool _dying;

		[SerializeField]
		private Color dyingColorMax;

		[SerializeField]
		private Color dyingColorMin;

		[HideInInspector]
		public int index;

		[HideInInspector]
		public MoveControlUI moveControl;

		private bool isActive;

		private bool isAlive;

		private int propertySaturation;

		private int propertyBrightness;

		private CharacterSelector csDragon;

		private VisibleUIObject rebornRootVisible;

		private VisibleUIObject rebornTimeVisible;

		private List<RebornLifeIconUI> rebornIconList;

		private bool isUpdateRebornTimer;

		public bool Dying
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[HideInInspector]
		public int playerNo
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CharacterBase owner
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Initialize(ButtonDelegate click, int idx, float scaleFactor, bool isUnlimitReborn, int rebornNum)
		{
		}

		public override void FastUpdate()
		{
		}

		public void SetHPGauge(bool immediate)
		{
		}

		public void SetTimeGauge(DragonCharacter dragon, float value, bool immediate)
		{
		}

		public void SetShieldGauge(bool immediate)
		{
		}

		public void SetImage(CharacterBase chara, Material face, Material faceMono, Sprite sprite, Sprite spriteMono)
		{
		}

		private void ChangeImage(bool alive)
		{
		}

		public bool IsActive()
		{
			return default(bool);
		}

		public void Active(bool b)
		{
		}

		public Vector2 GetButtonPosition()
		{
			return default(Vector2);
		}

		private void SetDying(bool value)
		{
		}

		public void SetPlayerNo(int no)
		{
		}

		public Sprite GetPlayerNoImage(int no)
		{
			return null;
		}

		private static int GetSign(float rate)
		{
			return default(int);
		}

		public void SetEnableButton(bool isEnable)
		{
		}

		public void SetEnableRebornIcon(bool isUnlimitReborn, int enableCount)
		{
		}

		public void SetEnableRebornIconOtherPlayer(int playerNo, bool isUnlimitReborn, int rebornNum)
		{
		}

		public void SetVisibleRebornIcon(int enableCount)
		{
		}

		public void SetRebornTime(float elapsed, float duration)
		{
		}

		public int GetVisibleRebornIconNum()
		{
			return default(int);
		}

		public int GetEnablelRebornIconNum()
		{
			return default(int);
		}

		private bool IsShowRebornCountUI()
		{
			return default(bool);
		}
	}
}
