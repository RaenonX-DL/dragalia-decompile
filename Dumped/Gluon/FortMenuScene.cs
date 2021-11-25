using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class FortMenuScene : SceneBase
	{
		private enum TutorialType
		{
			None,
			Fort,
			Craft,
			CastleStory
		}

		public Camera mainCamera;

		public FortMenuCharaTalkSelector charaTalkSelector;

		public static string prefabDir;

		private FortMenuUICanvas mainCanvas;

		private FortMenuCharaCanvas charaCanvas;

		private bool isRequestFortInfoCompleted;

		private bool isRequestDragonContactInfoCompleted;

		private bool isTutorialRequired;

		private string charaVoiceGroupName;

		private GameObject charaCanvasPrefab;

		private TutorialType tutorialType;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		public override void OnPresentReceived()
		{
		}

		public void OnCharaPressed()
		{
		}

		private void SetupTutorialState()
		{
		}

		private void StartTutorial()
		{
		}

		private void Tutorial_ToFort()
		{
		}

		private void Tutorial_CastleStory()
		{
		}

		private IEnumerator Tutorial_CastleStory_Coroutine()
		{
			return null;
		}

		private void CheckBadges()
		{
		}

		public void RequestFortInfo()
		{
		}

		public void RequestDragonContactInfo()
		{
		}
	}
}
