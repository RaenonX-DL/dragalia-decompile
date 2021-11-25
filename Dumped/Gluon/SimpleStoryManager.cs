using System;
using UnityEngine;

namespace Gluon
{
	public class SimpleStoryManager : MonoBehaviour
	{
		private enum SortingOrder
		{
			Character = 150,
			UIBackground,
			UIMain
		}

		public CameraGroup characterCamera;

		private GameObject storyCanvasObject;

		private GameObject storyBgCanvasObject;

		private GameObject storyCharaCanvasObject;

		public void SetupStory()
		{
		}

		public void ExecScript(string scriptName, Action onCompleted)
		{
		}
	}
}
