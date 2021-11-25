using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BottomNode : MonoBehaviour
	{
		public GameObject touchEventNode;

		public GameObject facilityLevelupButton;

		public Button levelUpButton;

		public Text levelUpMaxText;

		public Color leveUpButtonDisableColor;

		public GameObject facilityRelocationButton;

		public GameObject facilityStoreButton;

		public GameObject facilityInfoButton;

		public GameObject stopButton;

		public GameObject completeAtOnceButton;

		public AnimationUIGroup facilityNameGroup;

		public Text facilityText;

		private FacilityViewController curFacilityTextVc;

		private RectTransform facilityButtonsParentRect;

		private float facilityButtonsParentRectOriginalWidth;

		private FortViewController fortViewCtrl;

		public AnimationUIGroup moveGroup;

		private bool isSlideIn;

		private void Start()
		{
		}

		public void OnInit(FortViewController fortViewCtrl)
		{
		}

		public bool IsSetFacilityText(FacilityViewController facilityVc)
		{
			return default(bool);
		}

		public void OnSelectFacility(FacilityViewController facilityViewController)
		{
		}

		private string GetFacilityText(Facility facility)
		{
			return null;
		}

		public void SlideOut()
		{
		}

		public void SlideIn(bool isButtonDisable = false)
		{
		}

		private void InteractableButton(bool isInteractable)
		{
		}

		private void UpdateLevelUpInteractable()
		{
		}
	}
}
