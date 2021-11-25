using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ProfileScene : SceneBase
	{
		public Canvas mainCanvas;

		public GameObject bgPanel;

		public Image charaImage;

		public GameObject downloadGreenLight;

		private Canvas popupBaseCanvas;

		private string playerIDStr;

		private string playerNameStr;

		private PlayerProfile profile;

		private EditNameDialog editDialog;

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

		public void JumpAnotherName()
		{
		}

		public void EditNameButtonPressed()
		{
		}

		public void CopyIDButtonPressed()
		{
		}

		private void ShowEditNameWindow()
		{
		}
	}
}
