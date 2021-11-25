using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class UiImageExchanger : MonoBehaviour
	{
		public class IndexReceiver
		{
			public int index;
		}

		[Serializable]
		public class IndexReceiveEvent : UnityEvent<IndexReceiver>
		{
		}

		[SerializeField]
		protected Image targetImage;

		[SerializeField]
		protected Sprite[] exchangeSprites;

		[SerializeField]
		protected Material[] exchangeMaterials;

		[SerializeField]
		[Header("ã\u0082¤ã\u0083³ã\u0083\u0087ã\u0083\u0083ã\u0082\u00afã\u0082¹å\u008f\u0096å¾\u0097ã\u0082¤ã\u0083\u0099ã\u0083³ã\u0083\u0088")]
		public IndexReceiveEvent indexGetter;

		[SerializeField]
		[Header("ã\u0083\u0095ã\u0083\u0083ã\u0082¿ã\u0083¼ã\u0082¿ã\u0083\u0096æ\u008c\u0087å®\u009aã\u0082\u0092ä½¿ã\u0081\u0086(ã\u0082¤ã\u0083\u0099ã\u0083³ã\u0083\u0088è\u00a8­å®\u009aã\u0081®æ\u0096¹ã\u0081\u008cå\u0084ªå\u0085\u0088ï¼\u0089")]
		private bool isUseFooterMenuTabIndex;

		private IndexReceiver myIndexReceiver;

		private void Start()
		{
		}

		public virtual void SetImage(int index, bool isOverrideSprite = false)
		{
		}
	}
}
