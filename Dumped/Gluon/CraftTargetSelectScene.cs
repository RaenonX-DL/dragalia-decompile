using System.Collections;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class CraftTargetSelectScene : CraftEffectSceneBase
	{
		public static bool isShowCraftPage;

		[SerializeField]
		private Transform overlayParent;

		private CraftTargetSelectMainCanvas mainCanvas;

		private WeaponCraftDataElement craftTargetData;

		private CraftCreateResponse craftResponse;

		private bool isReloadList;

		private bool isGoToPowerup;

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

		private IEnumerator LoadCraftDataCoroutine()
		{
			return null;
		}

		private void OnEnterScene()
		{
		}

		private void OnDestroy()
		{
		}

		public void BackButtonPressed()
		{
		}

		public override void OnPresentReceived()
		{
		}

		private void LoadCraftList(WeaponType type)
		{
		}

		private void LoadEvolutionList(bool isShowAll)
		{
		}

		private void TabChangeCallBack(WeaponType type)
		{
		}

		private void OnCraftCellButtonPressed(CraftTargetSelectCellData cellData, bool isUseBackup = false)
		{
		}

		private void OnTreeButtonPressed(CraftTargetSelectCellData cellData)
		{
		}

		private void SendCraftData(CraftStepupSendData sendData)
		{
		}

		private void FooterButtonPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		private void ChangeSceneCallback(UnityAction nextSceneCallback)
		{
		}

		private void TabSelected(int index)
		{
		}

		private ulong[] CreateDataIdList()
		{
			return null;
		}

		public static bool IsEnableGradeup(WeaponCraftDataElement masterCraftData, int weaponId)
		{
			return default(bool);
		}

		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void GoNextScene(ulong baseKeyId)
		{
		}

		public void GoNextSceneByMasterId(int baseMasterId)
		{
		}

		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		public void OnSortButtonClicked()
		{
		}

		protected override void SetupCraftEffectData()
		{
		}

		private void AfterResultAction()
		{
		}

		protected override void CloseCraftEffect()
		{
		}

		protected override bool PlayNextEffect(bool isBackKey = false)
		{
			return default(bool);
		}

		private void OnDismantleWeaponButtonPressed()
		{
		}

		private void SetupTutorial()
		{
		}

		private void Tutorial_2_6_2()
		{
		}

		private IEnumerator Tutorial_2_6_2_Coroutine()
		{
			return null;
		}

		private void Tutorial_2_6_2_ToFort()
		{
		}

		private IEnumerator Tutorial_2_6_2_ToFort_Coroutine()
		{
			return null;
		}
	}
}
