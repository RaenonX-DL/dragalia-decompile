using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PurchaseStonePopup : ShopCommonPopup
	{
		[SerializeField]
		[Header("Tableview")]
		public PurchaseStoneTableViewController tableview;

		[SerializeField]
		[Header("TopPart")]
		public Transform topPart;

		public Text ownedPaidStoneText;

		public static void CreateModule(GameObject destroyWatcher, Action onPurchaseDone, Action onCancelled)
		{
		}

		public static void CreateModuleForShopSceneCompatibility(GameObject destroyWatcher, Action onPurchaseDone, Action onCancelled, bool isDialog, Transform frameParent, RectTransform referenceRect)
		{
		}

		public static void ReloadModuleData()
		{
		}

		public void ReloadContents()
		{
		}

		protected override void Start()
		{
		}

		private static void RequestForPaymentData()
		{
		}

		private static void UpdateStoneShopData(Action onLoadDone)
		{
		}

		private static void CreateCurrentModule()
		{
		}

		private static void OnClosePopup()
		{
		}

		protected override void OnPanelModeSet()
		{
		}
	}
}
