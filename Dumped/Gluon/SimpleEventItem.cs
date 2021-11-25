using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	[Serializable]
	public class SimpleEventItem
	{
		[SerializeField]
		private GameObject root;

		[SerializeField]
		private Text simpleEventItemCount;

		[SerializeField]
		private Image simpleEventItemIcon;

		public void SetItem(int itemCount, GiftType viewEntityType, int viewEntityId)
		{
		}
	}
}
