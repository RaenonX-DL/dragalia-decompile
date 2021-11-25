using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class FortPullMenu : MonoBehaviour
	{
		public bool isAnimation;

		public bool isOpened;

		[SerializeField]
		private GameObject openedMenu;

		[SerializeField]
		private GameObject closedMenu;

		[SerializeField]
		private Button viewModeButton;

		[SerializeField]
		private Button fortDetailButton;

		[SerializeField]
		private Button invisibleButton;

		[SerializeField]
		private AnimationUIExpand pullMenuExpand;

		[SerializeField]
		private AnimationUIGroup progressiveMove;

		public UnityEvent onManagedFacilityButtonPressed;

		public UnityEvent onViewModeButtonPressed;

		public UnityEvent onFortDetailButtonPressed;

		public UnityEvent onInvisibleButtonPressed;

		private RuntimeAnimatorController viewModeButtonAnimatorController;

		private RuntimeAnimatorController fortDetailButtonAnimatorController;

		private RuntimeAnimatorController invisibleButtonAnimatorController;

		public float pullMenuMoveDuration => default(float);

		private void Awake()
		{
		}

		public void OnPullMenuButtonPressed()
		{
		}

		public void SlideIn()
		{
		}

		public void SlideOut()
		{
		}

		public void OnSlideInEnd()
		{
		}

		public void OnSlideOutEnd()
		{
		}

		public void OnManagedFacilityButtonPressed()
		{
		}

		public void OnViewModeButtonPressed()
		{
		}

		private void UpdateViewModeIcon()
		{
		}

		public void OnFortDetailButtonPressed()
		{
		}

		public void OnInvisibleButtonPressed()
		{
		}

		public void SetAllButtonAnimatorController(RuntimeAnimatorController animatorController, bool isInteractable, bool isBackup = false)
		{
		}

		public void SetBackAllButtonAnimatorController(bool isInteractable = true)
		{
		}

		private RuntimeAnimatorController SetButtonAnimatorController(Button button, bool isInteractable, RuntimeAnimatorController animatorController)
		{
			return null;
		}
	}
}
