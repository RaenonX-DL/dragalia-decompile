using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthManaCircleUICanvas : MonoBehaviour
	{
		[HideInInspector]
		public GrowthManaCircleScene scene;

		public GameObject star;

		public GameObject manaPoint;

		public GameObject platinumCrystalNum;

		public Button menuButton;

		public Button autoButton;

		public Button platinumButton;

		public Button abilityListButton;

		public Button screenSaverTouchGuard;

		public Text abilityDetailButtonText;

		public Text growthButtonText;

		public Text autoButtonText;

		public Text manaPointText;

		public Text releasedNumText;

		public Text platinumCrystalCountText;

		[SerializeField]
		private Image usePlatinumCrystalButtonImage;

		[SerializeField]
		private Sprite spriteUsePlatinumCrystal1;

		[SerializeField]
		private Sprite spriteUsePlatinumCrystal2;

		public GameObject screenSaverButton;

		public GameObject onlineButton;

		public GameObject firstEnterEffectButton;

		private Vector2 normalStarPosition;

		private Vector2 normalPlatinumNumPosition;

		private Vector2 normalManaPointPosition;

		private Vector2 normalAbilityListPosition;

		private Vector2 normalPlatinumButtonPosition;

		private Vector2 normalMenuPosition;

		private Vector2 normalAutoPosition;

		private Vector2 normalBackButtonPosition;

		private Vector2 autoButtonDelta;

		private Vector2 menuButtonDelta;

		private Vector2 backButtonDelta;

		private Vector2 manaPointDelta;

		private Vector2 abilityListButtonDelta;

		private Vector2 starDelta;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void Reload()
		{
		}

		public void ActivateScreenSaverTouchGuard(bool active)
		{
		}

		public void StartEnterAnimation(float duration = 18f)
		{
		}

		private void StartEnterAnimationParts(GameObject obj, float delay, Vector2 delta, float duration)
		{
		}

		public void StartExitAnimation(float duration = 12f)
		{
		}

		private Vector3 StartExitAnimationParts(GameObject obj, float delay, Vector2 vec, float duration)
		{
			return default(Vector3);
		}

		public void StartScreenSaverEnterAnimation(float duration = 24f)
		{
		}

		private Vector3 StartScreenSaverEnterAnimationParts(GameObject obj, float delay, Vector2 vec, float duration)
		{
			return default(Vector3);
		}

		public void StartScreenSaverExitAnimation(float duration = 24f)
		{
		}

		private void StartScreenSaverExitAnimationParts(GameObject obj, float delay, Vector3 targetPos, float duration)
		{
		}

		public void OnAutotButtonPressed()
		{
		}

		public void OnManaCircleMenuButtonPressed()
		{
		}

		public void OnAbilityListButtonPressed()
		{
		}

		public void OnScreenSaverTouchGuardPressed()
		{
		}

		public void OnAllReleaseuttonPressed()
		{
		}

		public void OnFirstEnterEffctPressed()
		{
		}

		public void OnOfflineButtonPressed()
		{
		}

		public void OnPlatinumCrystalPressed()
		{
		}
	}
}
