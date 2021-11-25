using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyEquipCrest : MonoBehaviour
	{
		[SerializeField]
		private GameObject type1Slot;

		[SerializeField]
		private GameObject type2Slot;

		[SerializeField]
		private GameObject type3Slot;

		[SerializeField]
		private Image crestIcon;

		[SerializeField]
		private CommonUnionIcon crestUnionIcon;

		[SerializeField]
		private Text releaseCount;

		[SerializeField]
		private Text ability;

		[SerializeField]
		private Image unionIcon;

		[SerializeField]
		private GameObject lockObject;

		[SerializeField]
		private GameObject emptyObject;

		[SerializeField]
		private GameObject crestInfoObject;

		[SerializeField]
		private Button button;

		[SerializeField]
		private GameObject eventBonusIcon;

		[SerializeField]
		private GameObject noneUnionGameObject;

		[SerializeField]
		private FlashPlayerManager flashPlayerManager;

		private const string unionBonusFlashPath = "Prefabs/OutGame/Party/Flash/{0}";

		private Dictionary<string, FlashPlayer> effectDictionary;

		private int crestId;

		private int slotType;

		private int slotIndex;

		private Action onChangedCallback;

		private bool isSupportFriend;

		public static PartyEquipCrestSelectPopup crestSelectPopup;

		private void OnDestroy()
		{
		}

		public void Setup(int slotIndex, int slotType, int crestId, Action onChangedCallback, bool isSupportFriend = false)
		{
		}

		public void PlayUnionBonusEffect(string effectName)
		{
		}

		private void PrepareFlash(string effectName)
		{
		}

		private void ResetFlash(string effectName)
		{
		}

		public void SetupLock(int slotIndex, int slotType)
		{
		}

		private void SetupSlot(int slotType)
		{
		}

		public void OnChangeButtonPressed()
		{
		}

		public void OpenDetailScene()
		{
		}

		public void SetupCrestSetCell(int slotIndex, int slotType, int crestId, bool isLockSlot)
		{
		}
	}
}
