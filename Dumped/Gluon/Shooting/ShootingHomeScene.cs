using System.Collections;
using UnityEngine;

namespace Gluon.Shooting
{
	public class ShootingHomeScene : SceneBase
	{
		public enum EpilogueState
		{
			none,
			startFadeIn,
			startBlackOut,
			textFadeIn,
			textWate,
			textFadeOut,
			end,
			backKey
		}

		[SerializeField]
		private Camera mainCamera;

		[SerializeField]
		private Camera uiCamera;

		private ShootingHomeBGCanvas bgCanvas;

		private ShootingHomeUiCanvas uiCanvas;

		private HomeScoreBoardCanvas scoreBoard;

		public bool isScoreBoardActive;

		public static string prefabDir;

		public bool debugForceLoadEnding;

		private static ShootingHomeScene instance;

		public EpilogueState epilogueState;

		public static ShootingHomeScene Instance => null;

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		public void BGFadeIn(bool isNormal)
		{
		}

		public void FinishFadeIn()
		{
		}

		public void ActiveScoreBoard()
		{
		}

		public void HideScoreBoard()
		{
		}

		public void SetPostEffect(bool isActive)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
