using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class AlbumPictureBookScene : SceneBase
	{
		[SerializeField]
		private Camera mainCamera;

		private Canvas albumCanvas;

		private AlbumPictureBookCanvas albumPictureBookCanvas;

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

		public override void OnPresentReceived()
		{
		}

		public override void OnItemUsed()
		{
		}
	}
}
