using System.Collections;
using Cute.AssetBundle;
using UnityEngine;

namespace Gluon
{
	public class StoryScene : SceneBase
	{
		[SerializeField]
		protected GameObject cameraRootObject;

		private StoryCanvas mainCanvas;

		private DownloadOperation downloadOperation;

		private void Start()
		{
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		public override void OnBeforeLeaving()
		{
		}

		private void OnDestroy()
		{
		}

		public StoryCanvas GetStoryCanvas()
		{
			return null;
		}
	}
}
