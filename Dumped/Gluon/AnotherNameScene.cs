using System.Collections;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class AnotherNameScene : SceneBase
	{
		public GameObject httpGreenLight;

		private Canvas mainCanvas;

		private AnotherNameCellData nowSelectData;

		private NowSetName nowSetName;

		private NameListBase nameListBase;

		private EmblemList[] allNameList;

		private AnotherNameListController anotherNameListController;

		private readonly string mainCanvasPath;

		private IEnumerator Start()
		{
			return null;
		}

		private void OnDestroy()
		{
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

		public override void OnPresentReceived()
		{
		}

		public void BackButtonPressed()
		{
		}

		public void NameButtonPressed(AnotherNameCellData selectData)
		{
		}

		private void SendAnotherNameData()
		{
		}

		private void SetDataOnSuccess(EmblemSetResponse res)
		{
		}

		private void GetAnotherNameData()
		{
		}

		private void GetDataOnSuccess(EmblemGetListResponse res)
		{
		}

		public void RequestUpdateResetNewFlag(EmblemList[] emblemList)
		{
		}

		private void ShowCompleteDialog()
		{
		}

		private void ShowSortDialog()
		{
		}

		private void SetSortInfo(AnotherNameSortData sortData)
		{
		}
	}
}
