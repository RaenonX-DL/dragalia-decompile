using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class AlbumEnemyMemoryScene : SceneBase
	{
		[SerializeField]
		private Camera mainCamera;

		private Canvas albumCanvas;

		private void Start()
		{
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		private void BackButtonPressed()
		{
		}
	}
}
