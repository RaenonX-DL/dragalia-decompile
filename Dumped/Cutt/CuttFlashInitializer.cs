using System.Collections.Generic;
using Gluon;
using UnityEngine;

namespace Cutt
{
	public class CuttFlashInitializer : MonoBehaviour
	{
		[SerializeField]
		public List<CuttFlashInitializeData> initializeDataList;

		private bool isInitialized;

		private bool isPlayingInGame;

		public CuttFlashController GetFlashController(int index)
		{
			return null;
		}

		public bool IsInitialized()
		{
			return default(bool);
		}

		public void Load(bool isPlayingInGame, GameObject canvasObject)
		{
		}

		private CuttFlashController LoadFlash(CuttFlashInitializeData initData, GameObject canvasObject, int index)
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
