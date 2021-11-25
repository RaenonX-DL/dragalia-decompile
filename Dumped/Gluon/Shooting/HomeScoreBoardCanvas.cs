using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon.Shooting
{
	public class HomeScoreBoardCanvas : AnimationUICanvas
	{
		[SerializeField]
		private Animator titleAnimator;

		[SerializeField]
		[Header("TabImage")]
		public Sprite[] spliteList;

		public Image[] tabImageList;

		[SerializeField]
		private Animator[] tabAnimatorList;

		[SerializeField]
		private Transform[] platePos;

		[SerializeField]
		private GameObject[] rankingParent;

		private List<HomeScoreBoardPlate>[] rankingPlateList;

		private void Start()
		{
		}

		public void Appear()
		{
		}

		public void Hide()
		{
		}

		public void OnNormalModeButtonPressed()
		{
		}

		public void OnHardMordButtonPressed()
		{
		}

		public void OnNightmareMordButtonPressed()
		{
		}

		private void OnGameMordButtonPressed(STGDataManager.Mode mode, bool isPlaySe = true)
		{
		}

		private void ChangeTabImage(STGDataManager.Mode currentMode, STGDataManager.Mode mode)
		{
		}

		private void PlateListAnimationStart(STGDataManager.Mode currentMode, STGDataManager.Mode mode)
		{
		}

		private IEnumerator PlateListInAnim(STGDataManager.Mode mode)
		{
			return null;
		}

		private void PlateListOutAnim(STGDataManager.Mode mode, bool isHide = false)
		{
		}

		private HomeScoreBoardPlate CreateScoreBordPlate(GameObject parent)
		{
			return null;
		}

		private void StartUIAnim(Animator animator, bool isIn, float diray = 0f)
		{
		}

		private IEnumerator StartUIAnimWithWaight(Animator animator, bool isIn, float diray)
		{
			return null;
		}

		private bool IsClearedNormal()
		{
			return default(bool);
		}

		private bool IsReleaseNightmare()
		{
			return default(bool);
		}

		protected override void OnDestroy()
		{
		}
	}
}
