using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon.Shooting
{
	public class ShootingHomeUiCanvas : AnimationUICanvas
	{
		[SerializeField]
		private Animator logoImageAnimator;

		[SerializeField]
		private Animator gameStartButtonAnimator;

		[SerializeField]
		private Animator backButtonAnimator;

		[SerializeField]
		private Animator scoreBoardButtonAnimator;

		[SerializeField]
		private Animator titleButtonAnimator;

		[SerializeField]
		private Animator modeSelectNodeAnimator;

		[SerializeField]
		private Animator modeSelectNightMareAnimator;

		[SerializeField]
		private Animator whiteScreenAnimator;

		[SerializeField]
		private Animator blackScreenAnimator;

		[SerializeField]
		private Animator textAttention;

		private static ShootingHomeScene shootingHomeScene;

		private const int homeBackKeyEventNum = 0;

		private const int rankingBackKeyEventNum = 1;

		private const int modeSelectBackKeyEventNum = 2;

		private const int endingBackKeyEventNum = 3;

		private void Start()
		{
		}

		private void AppearUI()
		{
		}

		private IEnumerator EpilogueAnim()
		{
			return null;
		}

		public void OnGameStartButtonPressed()
		{
		}

		public void OnScoreBoardButtonPressed()
		{
		}

		private IEnumerator AfterScoreBoardButtonPressed()
		{
			return null;
		}

		public void OnTitleButtonPressed()
		{
		}

		private IEnumerator AfterTitleButtonPressed()
		{
			return null;
		}

		public void OnNormalModeButtonPressed()
		{
		}

		public void OnHardMordButtonPressed()
		{
		}

		public void OnNightMareMordButtonPressed()
		{
		}

		public void OnBackButtonPressed()
		{
		}

		public void OnTransparentButtonPressed()
		{
		}

		private void StartButtonsAnimation(bool isIn)
		{
		}

		private IEnumerator CloseShootingHome()
		{
			return null;
		}

		private void GoMyPage()
		{
		}

		private void OnStartShooting(STGDataManager.Mode mode)
		{
		}

		private void StartShooting()
		{
		}

		public bool IsFirstClear()
		{
			return default(bool);
		}

		private bool IsClearedNormal()
		{
			return default(bool);
		}

		private bool IsReleaseNightmare()
		{
			return default(bool);
		}

		private void StartLogoAnim(bool isIn)
		{
		}

		private void StartGameStartButtonAnim(bool isIn, float diray = 0f)
		{
		}

		private void StartBackButtonAnim(bool isIn, float diray = 0f)
		{
		}

		private void StartScoreBoardButtonAnim(bool isIn, float diray = 0f)
		{
		}

		private void StartTitleButtonAnim(bool isIn, float diray = 0f)
		{
		}

		private void StartModeSelectNodeAnim(bool isIn, float diray = 0f)
		{
		}

		private void StartUIAnim(Animator animator, bool isIn)
		{
		}

		private void StartUIAnim(Animator animator, bool isIn, float diray)
		{
		}

		private IEnumerator StartUIAnimWithWaight(Animator animator, bool isIn, float diray)
		{
			return null;
		}

		private void SetBuckKeyEvent(int sortingOrder, UnityAction action)
		{
		}

		private void RemoveBuckKeyEvent(int sortingOrder)
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
