using System.Collections;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class CraftNextStepSelectScene : CraftEffectSceneBase
	{
		public static ulong baseWeaponKeyId;

		public static int baseWeaponMasterId;

		public static bool isShowNextStepPage;

		public static int selectNodeId;

		[SerializeField]
		private Transform overlayParent;

		private CraftCreateResponse craftResponse;

		private CraftNextStepSelectMainCanvas mainCanvas;

		private int craftTargetId;

		private int[] materialIds;

		private bool isGoToPowerup;

		private bool isNeedUpdateList;

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		public override void OnPresentReceived()
		{
		}

		private void OnPrevSceneExitDone()
		{
		}

		private void OnInitReady()
		{
		}

		private IEnumerator LoadNextStepCoroutine()
		{
			return null;
		}

		private IEnumerator ReloadLoadListCoroutine()
		{
			return null;
		}

		private void LoadNextStepList()
		{
		}

		private void LoadTreeDiagram()
		{
		}

		private void OnEnterScene()
		{
		}

		public void BackButtonPressed()
		{
		}

		private void FooterButtonPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		private void ChangeSceneCallback(UnityAction nextSceneCallback)
		{
		}

		private void OnCraftCellButtonPressed(CraftTargetSelectCellData cellData, bool isUseBackup = false)
		{
		}

		private void CheckNewFlag(int weaponId, bool isChild = false, bool isUseBackup = false)
		{
		}

		private void ShowStepupCraftPopup(int weaponId, bool isUseBackup = false)
		{
		}

		private void SendCraftData(CraftStepupSendData sendData)
		{
		}

		private void GoCraftGradeUpScene(int weaponId, bool isChild)
		{
		}

		private void OnDestroy()
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
	}
}
