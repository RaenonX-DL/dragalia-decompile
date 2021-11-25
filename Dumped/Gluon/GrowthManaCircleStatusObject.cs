using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthManaCircleStatusObject : MonoBehaviour
	{
		public GrowthManaCircleStatusController controller;

		public Text hpText;

		public Text attackText;

		public Text powerText;

		public Text exAbilityText;

		public Text burstAttackText;

		public Text skillText;

		public Text abilityText;

		public Image exAbilityImage;

		public Image exAbility2Image;

		public Image burstAttackImage;

		public Image skill1Image;

		public Image skill2Image;

		public Image ability1Image;

		public Image ability2Image;

		public Image ability3Image;

		public Image exAbilityNotAvailableImage;

		public Image exAbility2NotAvailableImage;

		public Image burstAttackNotAvailableImage;

		public Image skill1NotAvailableImage;

		public Image skill2NotAvailableImage;

		public Image ability1NotAvailableImage;

		public Image ability2NotAvailableImage;

		public Image ability3NotAvailableImage;

		private RectTransform rectTransform;

		private CanvasGroup canvasGroup;

		private const float duration = 0.5f;

		private const float imageWidth = 774f;

		private const float imageY = -99f;

		private Color32 darkColor;

		private void Awake()
		{
		}

		public void Reload()
		{
		}

		public void SetAlpha(float value)
		{
		}

		public void StartShowingAnimation(int direction)
		{
		}

		public void StartHidingAnimation(int direction)
		{
		}

		private void OnAlphaAnimationUpdate(float value)
		{
		}

		private void OnPositionAnimationUpdate(float value)
		{
		}

		private void OnPositionAnimationComplete()
		{
		}
	}
}
