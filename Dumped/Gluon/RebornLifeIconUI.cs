using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class RebornLifeIconUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _rootRt;

		[SerializeField]
		[Tooltip("ONç\u0094»å\u0083\u008fã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _onRt;

		[SerializeField]
		[Tooltip("ã\u0083\u008fã\u0083¼ã\u0083\u0088ç\u0094»å\u0083\u008fã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _heartRt;

		[SerializeField]
		[Tooltip("ã\u0083ªã\u0083³ã\u0082°ç\u0094»å\u0083\u008fã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _ringRt;

		[SerializeField]
		[Tooltip("ã\u0082°ã\u0083©ã\u0083\u0087ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ç\u0094»å\u0083\u008fã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _gradationRt;

		[SerializeField]
		[Tooltip("ã\u0083\u008fã\u0083¼ã\u0083\u0088å¤§ç\u0094»å\u0083\u008fã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _heart2Rt;

		[SerializeField]
		[Tooltip("ONç\u0094»å\u0083\u008f")]
		private SpriteRenderer _onImage;

		[SerializeField]
		[Tooltip("ã\u0083\u008fã\u0083¼ã\u0083\u0088ç\u0094»å\u0083\u008f")]
		private SpriteRenderer _heartImage;

		[SerializeField]
		[Tooltip("ã\u0083ªã\u0083³ã\u0082°ç\u0094»å\u0083\u008f")]
		private SpriteRenderer _ringImage;

		[SerializeField]
		[Tooltip("ã\u0082°ã\u0083©ã\u0083\u0087ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ç\u0094»å\u0083\u008f")]
		private SpriteRenderer _gradationImage;

		[SerializeField]
		[Tooltip("ã\u0083\u008fã\u0083¼ã\u0083\u0088å¤§ç\u0094»å\u0083\u008f")]
		private SpriteRenderer _heart2Image;

		private VisibleUIObject _rootVisible;

		private Sequence _animSeq;

		private Color _workColor;

		private int _index;

		public bool isEnable
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

		public bool isVisible => default(bool);

		public static RebornLifeIconUI Create(GameObject pobj, GameObject parent, int index, bool enable, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize(int index, bool enable)
		{
		}

		private void OnDestroy()
		{
		}

		public void SetEnable(bool enable, bool force = false)
		{
		}

		public void SetVisible(bool visible)
		{
		}

		public void PlayShowAnim(float waitTime, [Optional] Action onComplete)
		{
		}

		public void PlayBlinkAnim()
		{
		}

		public void PlayConsumeAnim([Optional] Action onComplete)
		{
		}

		private void SetFade(ref SpriteRenderer image, float fade)
		{
		}
	}
}
