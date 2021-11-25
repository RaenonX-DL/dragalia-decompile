using System.Collections;
using Gluon.Http;

namespace Gluon
{
	public class DismantleWeaponScene : SceneBase
	{
		private DismantleWeaponCanvas mainCanvas;

		private ulong dismantleTargetId;

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

		private void OnEnterScene()
		{
		}

		public void BackButtonPressed()
		{
		}

		private void LoadCraftWeapon()
		{
		}

		private ulong[] CreateDataIdList()
		{
			return null;
		}

		public void OnSortButtonClicked()
		{
		}

		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void SendDismantleWeaponData(ulong keyId)
		{
		}

		private void ShowResultPop(CraftDisassembleResponse res)
		{
		}

		public override void OnPresentReceived()
		{
		}
	}
}
