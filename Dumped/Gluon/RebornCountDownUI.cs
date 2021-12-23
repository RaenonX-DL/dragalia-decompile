using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class RebornCountDownUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _rootRt;

		[SerializeField]
		[Tooltip("è\u0083\u008cæ\u0099\u00afã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _bgRt;

		[SerializeField]
		[Tooltip("å¾©æ\u00b4»ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _iconRt;

		[SerializeField]
		[Tooltip("æ\u0099\u0082é\u0096\u0093ç\u0094»å\u0083\u008f")]
		private SpriteRenderer _timeImage;

		[SerializeField]
		[Tooltip("ç\u0084¡å\u0088¶é\u0099\u0090å¾©æ\u00b4»å\u008a\u00a0ç®\u0097ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ç\u0094»å\u0083\u008f")]
		private SpriteRenderer _unlimitAddIconImage;

		[SerializeField]
		[Tooltip("ã\u0082µã\u0083¼ã\u0082\u00afã\u0083«ã\u0082²ã\u0083¼ã\u0082\u00b8å\u0088¶å¾¡")]
		private CircleGauge _gaugeCtrl;

		[SerializeField]
		[Header("resource")]
		[Tooltip("æ\u0095°å­\u0097ç\u0094»å\u0083\u008f")]
		private Sprite[] _numberSprites;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0081®é\u0085\u008dç½®é\u0096\u0093é\u009a\u0094")]
		private float _iconMerginX;

		private VisibleUIObject _rootVisible;

		private List<RebornLifeIconUI> _iconList;

		private Sequence _seqAnim;

		private Tweener _twUnlimitAddIconAnim;

		private int lastTimeImageIndex;

		private const int TIME_MAX_NUM = 9;

		public bool IsPlaying
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

		public bool IsVisible
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

		public static RebornCountDownUI Create(GameObject parent, bool isUnlimitReborn, int rebornNum, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize(GameObject lifePobj, bool isUnlimitReborn, int rebornNum)
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		public void Show(int restRebornCount, int consumeRebornCount)
		{
		}

		public void Hide()
		{
		}

		public void SetVisible(bool visible)
		{
		}

		public void SetTime(float elapsed, float duration)
		{
		}

		private void PlayShow()
		{
		}

		private void PlayHide()
		{
		}

		private void PlayIconBlink(int restRebornCount, int consumeRebornCount)
		{
		}

		private void PlayUnlimitAddIconBlink()
		{
		}

		private void OnUpdateUnlimitAddIconBlink(float fade)
		{
		}

		private void SetFade(SpriteRenderer obj, float fade)
		{
		}

		public static void SetEnableIcon(ref List<RebornLifeIconUI> list, int enableCount)
		{
		}

		public static void SetVisibleIcon(ref List<RebornLifeIconUI> list, int enableCount)
		{
		}

		public static void SetFade(ref List<RebornLifeIconUI> list, float fade)
		{
		}

		public static int GetTimeToImageIndex(float time)
		{
			return default(int);
		}

		public static int GetPartyCharaRebornNum(int rebornNum, int partyCharaNum, int partyIndex)
		{
			return default(int);
		}
	}
}
