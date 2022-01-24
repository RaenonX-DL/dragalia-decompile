using System;
using System.Collections;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class ShopTradeScene : SceneBase
	{
		[SerializeField]
		[Header("SwitchablePanels")]
		private Transform currentPanelNode;

		[SerializeField]
		private Transform nextPanelNode;

		[SerializeField]
		private Transform commonPanelNode;

		[SerializeField]
		private Transform tempPanelNode;

		[SerializeField]
		[Header("HttpGreenLight")]
		private GameObject httpGreenLight;

		public Camera mainUICamera;

		public Camera flashCamera;

		[HideInInspector]
		public Canvas canvas;

		private bool bPrevPanelExitDone;

		private bool bNextHttpReady;

		private ShopTradePanelBase activePanel;

		private Coroutine waitReadyStateCoroutine;

		private ShopCommonPage commonPage;

		public bool isTutorialRequired;

		private bool stopNextTopHttpRequestForInit;

		public ShopTradePanelBase GetActivePanel()
		{
			return null;
		}

		public ShopCommonPage GetCommonPage()
		{
			return null;
		}

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void OnPrevSceneExitDone()
		{
		}

		private void OnInitReady()
		{
		}

		private void LoadBG()
		{
		}

		private void LoadCommonPage()
		{
		}

		private void OnEnterScene()
		{
		}

		public override void StartExitAnimation()
		{
		}

		public void SwitchToPanel(ShopTradeModel.PanelType type, int scrollToItem = 0, [Optional] Action<ShopTradePanelBase> onNewPanelLoaded)
		{
		}

		private IEnumerator WaitForReadyState(ShopTradeModel.PanelType type, int scrollToItem = 0, [Optional] Action<ShopTradePanelBase> onNewPanelLoaded)
		{
			return null;
		}

		private void ReleasePanel(ShopTradeModel.PanelType type)
		{
		}

		private void RequestHttpForPanel(ShopTradeModel.PanelType type)
		{
		}

		private void OnDmodeGetDataSuccess(DmodeGetDataResponse res)
		{
		}

		public void LoadPanel(ShopTradeModel.PanelType type)
		{
		}

		public void SetNextHttpReady()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnPresentReceived()
		{
		}

		public override void OnItemUsed()
		{
		}

		private void ShopTutorial()
		{
		}

		private IEnumerator ShopTutorialCoroutine()
		{
			return null;
		}

		public void RefreshCommonPage()
		{
		}

		public static void GoToShopScene(ShopTradeModel.PanelType panel, ShopTradeProductData.CommonShopItemData.PackContentType scrollToItemType = ShopTradeProductData.CommonShopItemData.PackContentType.None, int scrollToItem = 0, ShopTradeProductData.CommonShopItemData.SpecialShopCategory specialShopCategory = ShopTradeProductData.CommonShopItemData.SpecialShopCategory.None)
		{
		}
	}
}
