using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SummonPickupCutin : MonoBehaviour
	{
		[SerializeField]
		[Header("Cutin")]
		public Image illustrationImage;

		public Image commentImage;

		public Image skillImage;

		public Image bottomInfoImage;

		public Image bgForAmuletImage;

		[SerializeField]
		[Header("Movements")]
		public Transform illustrationMovePart;

		public Transform bottomMovePart;

		public Transform postMovieInfoMovePart;

		public Transform movieFadeMovePart;

		public Transform coverUnitMovePart;

		[SerializeField]
		[Header("Cover")]
		public Image coverBGImage;

		public Image coverUnitImage;

		public Image coverCardImage;

		public Image topBannerImage;

		public Image topLogoImage;

		[SerializeField]
		private Image topActivePeriodImage;

		[SerializeField]
		private Text topActivePeriodText;

		[SerializeField]
		[Header("Page")]
		public GameObject cutinPage;

		public GameObject coverPage;

		[SerializeField]
		[Header("Animator")]
		public Animator cutinAnimator;

		private string pathOfPickupId;

		private int currentSummonId;

		private const float imageMoveDist = 120f;

		private const float imageMoveTime = 0.35f;

		private const float amuletImageMoveTime = 0.45f;

		private const float cutinFillInTime = 3f;

		private const float movieFadeOutTimeOffset = 0.55f;

		private const float postCutinMoveDistX = 380f;

		private const float postCutinMoveDistY = 30f;

		private const float postCutinSkillMoveDistY = 0f;

		private const float postCutinMoveTime = 0.75f;

		private const float postCutinSkillDelay = 0.15f;

		private const float movieFadeInOutTime = 0.4f;

		private const float movieFadeOutEndAlpha = 0.3f;

		private const float amuletIllustRotateZ = 5f;

		private List<Sequence> runningEnterSequenceList;

		private bool coverPageMode;

		private SummonTopItemData.PickupInfo pickupInfo;

		private void Awake()
		{
		}

		public void SwitchImagesBySummonIdAndIndex(SummonTopItemData data, SummonTopItemData.PickupInfo pickupInfo)
		{
		}

		private void DoRotateZAndFlip(Transform t, float moveTime, float z)
		{
		}

		private void DoMoveAndFade(Transform t, float distX, float distY, float moveTime, float delay = 0f, float fadeStartAlpha = 0f, float fadeEndAlpha = 1f)
		{
		}

		public void DoStabilizationAnimation()
		{
		}

		public void StartPostMovieAnimation()
		{
		}

		private IEnumerator HideMovieFadeOutCoroutine()
		{
			return null;
		}

		public void SkipRunningEnterSequences()
		{
		}

		public void TurnOff()
		{
		}

		private void SetImage(string assetsPath, Image image, string pathTemplate)
		{
		}

		private void ExchangeSprites()
		{
		}

		private string GenerateScheduleText(int summonId)
		{
			return null;
		}
	}
}
