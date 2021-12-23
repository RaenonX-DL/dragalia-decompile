using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class VesselBombUI : FastUpdateMonoBehaviour
	{
		private enum State
		{
			Count,
			CoolTime
		}

		private class SmokeImageInitData
		{
			private SpriteRenderer smokeImage;

			public Vector3 pos
			{
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public Vector3 scale
			{
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public void Setup(SpriteRenderer image)
			{
			}

			public void Reset()
			{
			}
		}

		[SerializeField]
		[Header("component")]
		[Tooltip("èª¿æ\u0095\u00b4ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform adjustRt;

		[SerializeField]
		[Tooltip("å\u008a¹æ\u009e\u009cã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform effectRt;

		[SerializeField]
		[Tooltip("å\u008a¹æ\u009e\u009cã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform effectAnimRt;

		[SerializeField]
		[Tooltip("ã\u0082\u00afã\u0083¼ã\u0083«ã\u0082¿ã\u0082¤ã\u0083\u00a0ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform coolTimeRt;

		[SerializeField]
		[Tooltip("ç\u0085\u0099ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform smokeRt;

		[SerializeField]
		[Tooltip("å\u008a¹æ\u009e\u009cç\u0094»å\u0083\u008f")]
		private SpriteRenderer effectImage;

		[SerializeField]
		[Tooltip("ç\u0085\u0099ç\u0094»å\u0083\u008fã\u0083ªã\u0082¹ã\u0083\u0088")]
		private SpriteRenderer[] smokeImageList;

		[SerializeField]
		[Tooltip("å\u008a¹æ\u009e\u009cã\u0082«ã\u0082¦ã\u0083³ã\u0083\u0088ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text countText;

		[SerializeField]
		[Tooltip("ã\u0082\u00afã\u0083¼ã\u0083«ã\u0082¿ã\u0082¤ã\u0083\u00a0ã\u0082²ã\u0083¼ã\u0082\u00b8å\u0088¶å¾¡")]
		private CircleGauge gaugeCtrl;

		[SerializeField]
		[Header("parameter")]
		private float countTextColorThreshold;

		[SerializeField]
		private Color[] countTextColorList;

		[SerializeField]
		private Color lowCountTextColor;

		[SerializeField]
		[Tooltip("ã\u0083\u0095ã\u0082£ã\u0083\u008bã\u0083\u0083ã\u0082·ã\u0083¥ã\u0082¢ã\u0083\u008bã\u0083¡å\u0086\u008dç\u0094\u009få\u0089\u008dã\u0081®å¾\u0085æ©\u009fæ\u0099\u0082é\u0096\u0093")]
		private float finishAnimWaitTime;

		[SerializeField]
		[Header("resource")]
		[Tooltip("å\u008a¹æ\u009e\u009cç\u0094»å\u0083\u008fã\u0083ªã\u0082½ã\u0083¼ã\u0082¹")]
		private Sprite[] effectSpriteList;

		private SmokeImageInitData[] smokeImageInitDataList;

		private VisibleUIObject rootVisible;

		private State state;

		private CharacterBase owner;

		private CharacterMarkUI markUI;

		private Sequence seqFinishAnim;

		private float countDispRemainTime;

		private int maxCount;

		private ExtraBuffType effectType;

		private Color currCountTextColor;

		private float maxCoolTime;

		private static int createCount;

		public int count
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

		public float coolTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isVisible
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

		public int index
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

		public static VesselBombUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize(int index, CharacterBase owner, CharacterMarkUI markUI)
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		public void Show()
		{
		}

		public void Hide(bool isReset = false)
		{
		}

		public bool SetCount(int count, int maxCount, bool isForce = false, bool isShow = true)
		{
			return default(bool);
		}

		public void SetEffectType(ExtraBuffType type, bool isForce = false)
		{
		}

		public bool SetCoolTime(float time, float maxTime, bool isForce = false, bool isShow = true)
		{
			return default(bool);
		}

		private bool IsShow()
		{
			return default(bool);
		}

		private bool IsParentVisible()
		{
			return default(bool);
		}

		private void PlayFinishAnim()
		{
		}

		public static void ResetCreateCount()
		{
		}
	}
}
