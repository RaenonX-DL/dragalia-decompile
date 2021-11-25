using System.Collections;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class StampScene : SceneBase
	{
		private Canvas mainCanvas;

		private Canvas popupBaseCanvas;

		private StampPageBase stampPageBase;

		private StampListFrame stampListFrame;

		private int pageselectStampId;

		private int listselectStampId;

		private bool goBackFlg;

		private StampSetData stampSetData;

		private int maxStampData;

		private string tab;

		private Footer.MenuTab menuTab;

		private Button saveButton;

		private readonly string mainCanvasPath;

		private readonly string stampVoice;

		private void Start()
		{
		}

		private IEnumerator UnloadScene()
		{
			return null;
		}

		private void StampPageChange()
		{
		}

		private void SaveButtonPressed()
		{
		}

		private void ShowConfirmDialog()
		{
		}

		private void ShowInfoDialog(int selectStampId)
		{
		}

		private void SaveStampData()
		{
		}

		private void StampListButtonPressed(int selectStampId)
		{
		}

		private void StampPageButtonPressed(int selectStampId)
		{
		}

		private bool CheckChangeStampSet()
		{
			return default(bool);
		}

		private void SendStampData()
		{
		}

		private void SendDataOnSuccess(StampSetEquipStampResponse res)
		{
		}

		private void GetStampData()
		{
		}

		private void GetDataOnSuccess(StampGetStampResponse res)
		{
		}

		public void RequestUpdateResetNewFlag(StampList[] stampList)
		{
		}

		private void UpdateResetNewRequestOnSuccess(UpdateResetNewResponse res)
		{
		}

		private void EdgeToEdgeComplete()
		{
		}

		private IEnumerator waitEdgeToEdgeComplete(StampList[] allStampList)
		{
			return null;
		}

		public void OnError(ErrorType errorType, int resultCode)
		{
		}

		private void OnFooterPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		private void OnHeaderPressed(UnityAction action)
		{
		}

		private void SaveButtonEnable(bool isEnable)
		{
		}

		public override void StartExitAnimation()
		{
		}

		public override void OnBeforeLeaving()
		{
		}

		public void OnDisable()
		{
		}
	}
}
