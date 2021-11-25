using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StorageExtensionPopup : CommonPopup
	{
		public enum StorageType
		{
			Weapon,
			Dragon,
			Amulet
		}

		[SerializeField]
		[Header("Texts")]
		private Text ownedStoneCountText;

		[SerializeField]
		private Text ownedPaidStoneCountText;

		[SerializeField]
		private Text commentText;

		[SerializeField]
		private Text[] onButtonPriceTexts;

		[SerializeField]
		[Header("OnOffs")]
		private GameObject insufficientGO;

		[SerializeField]
		private GameObject purchaseStoneImage;

		[SerializeField]
		private GameObject usePaidStoneImage;

		public GameObject insufficientStonePriceGO;

		public GameObject insufficientPaidStonePriceGO;

		public GameObject normalStonePriceGO;

		public GameObject normalPaidStonePriceGO;

		[SerializeField]
		[Header("Button")]
		private Button stoneButton;

		private Action<bool> onOk;

		public static StorageExtensionPopup Create(StorageType type, Action<bool> onOk)
		{
			return null;
		}

		private void InitByType(StorageType type, Action<bool> onOk)
		{
		}

		public void OnStoneButtonPressed(bool isPaidStone)
		{
		}
	}
}
