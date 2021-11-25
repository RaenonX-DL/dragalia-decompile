using System;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class PopupListButton : MonoBehaviour
	{
		[Serializable]
		public class EventInt : UnityEvent<int>
		{
		}

		[SerializeField]
		public EventInt iconPressed;

		[HideInInspector]
		private int iconIndex;

		private GiftType giftType;

		private GrowthScene.OnGrowCharaListPress callback;

		public void SetIconState(int inventoryId, GiftType type, GrowthScene.OnGrowCharaListPress setCallback)
		{
		}

		public void OnIconPressed()
		{
		}
	}
}
