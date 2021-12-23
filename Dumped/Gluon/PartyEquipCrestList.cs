using System;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyEquipCrestList : MonoBehaviour
	{
		private enum SlotState
		{
			None,
			Enable,
			Locked
		}

		[SerializeField]
		private PartyEquipCrest[] crestList;

		[SerializeField]
		private PartyEquipTalisman talismanCell;

		[SerializeField]
		private GameObject emptyMessageObject;

		[SerializeField]
		private VerticalLayoutGroup layout;

		[SerializeField]
		private RectTransform frameRectTransform;

		private WeaponBodyList userWeaponData;

		private WeaponBodyElement weaponData;

		public Action onCrestChangeCallback;

		public void Reload(bool isSupportFriend = false)
		{
		}

		private SlotState GetSlotState(int index)
		{
			return default(SlotState);
		}

		private int GetSlotType(int index)
		{
			return default(int);
		}
	}
}
