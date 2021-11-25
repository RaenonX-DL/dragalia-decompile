using System;
using System.Runtime.InteropServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class InGameCounterUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private RectTransform _rootRt;

		[SerializeField]
		private SpriteRenderer[] _countImage;

		[SerializeField]
		private SpriteRenderer[] _animCountImage;

		[SerializeField]
		private SpriteRenderer _symbolImage;

		[SerializeField]
		private SpriteRenderer _animSymbolImage;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0082«ã\u0082¦ã\u0083³ã\u0083\u0088ã\u0082\u0092è¡\u00a8ç¤ºã\u0081\u0099ã\u0082\u008bæ\u009c\u0080ä½\u008eå\u0080¤")]
		private int _minDisplayCount;

		[SerializeField]
		[Tooltip("ã\u0082·ã\u0083³ã\u0083\u009cã\u0083«ã\u0081®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088å\u0080¤")]
		private Vector2 _symbolOffset;

		[SerializeField]
		[Tooltip("ã\u0082·ã\u0083³ã\u0083\u009cã\u0083«ã\u0081®æ\u009b\u00b4æ\u0096°æ\u009c\u0089å\u008a¹ã\u0083\u0095ã\u0083©ã\u0082°")]
		private bool _isEnableSymbol;

		[SerializeField]
		[Tooltip("ã\u0082«ã\u0082¦ã\u0083³ã\u0083\u0088ã\u0081\u008cå\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0082\u008fã\u0081£ã\u0081\u009fé\u009a\u009bã\u0081®ã\u0082¢ã\u0083\u008bã\u0083¡UI")]
		private InGameAnimUI[] _changeAnimUI;

		[SerializeField]
		[Header("resource")]
		[Tooltip("æ\u0095°å­\u0097ç\u0094»å\u0083\u008f")]
		private Sprite[] _countSprite;

		private VisibleUIObject _rootVisible;

		private Vector3[] _countOriginalScale;

		private long _maxCount;

		private long _lastCount;

		private bool _isEnableAnim;

		private Action<long, long> _onCountChanged;

		public void Initialize([Optional] Action<long, long> onCountChanged)
		{
		}

		private void OnDestroy()
		{
		}

		public void Visible(bool b)
		{
		}

		public bool IsVisible(bool inHierarchy = true)
		{
			return default(bool);
		}

		public void SetCount(long count, bool isForce = false, bool isAnim = true)
		{
		}

		public long GetMaxCount()
		{
			return default(long);
		}

		private void SetCountSprite(long count, long maxCount)
		{
		}

		private void SetCountSprite(int index, int countIndex, bool enabled)
		{
		}

		public void SetColor(Color color, bool isApplyAnimCount)
		{
		}

		private bool PlayChangeAnim()
		{
			return default(bool);
		}
	}
}
