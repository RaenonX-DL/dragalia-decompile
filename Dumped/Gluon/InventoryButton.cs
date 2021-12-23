using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InventoryButton : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0083\u0090ã\u0083\u0083ã\u0082\u00b8ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _badgeIconRt;

		[SerializeField]
		[Tooltip("ã\u0083\u009cã\u0082¿ã\u0083³")]
		private Button _button;

		public bool isVisibleBadgeIcon
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

		public static InventoryButton Create(GameObject parent, int index, Action<InventoryButton> onClick, bool isLeft)
		{
			return null;
		}

		public void Initialize(Action<InventoryButton> onClick)
		{
		}

		public void VisibleBadgeIcon(bool b, bool isForce = false)
		{
		}
	}
}
