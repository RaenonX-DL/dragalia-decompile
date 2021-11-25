using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class HeaderCanvas : MonoBehaviour
	{
		public enum Direction
		{
			Horizontal,
			Vertical
		}

		private enum CaptionAnimationRequest
		{
			Enter,
			Exit
		}

		public static bool ignoreUpdatePresentBadge;

		public Header header;

		public Image headerImage;

		public CaptionCanvas captionCanvas;

		public GameObject iPhoneXBase;

		public GameObject presentBg;

		public GameObject menuBg;

		public GameObject[] presentBgs;

		public GameObject[] menuBgs;

		public HeaderMenuButton menuButton;

		public Badge presentBadge;

		public Badge menuBadge;

		public bool isSlideOut;

		public bool keepMenuButtonSelectedImage;

		private Canvas canvas;

		private bool isAnimating;

		[SerializeField]
		private float slideDistanceHeader;

		[SerializeField]
		private float slideDistanceCaption;

		private RectTransform headerRectTrans;

		private RectTransform captionRectTrans;

		private RectTransform presentButtonRectTrans;

		private RectTransform menuButtonRectTrans;

		private float defaultYHeader;

		private float defaultYCaption;

		private float defaultYItem;

		private Queue<CaptionAnimationRequest> captionAnimationRequestList;

		private static HeaderCanvas _instance;

		public static HeaderCanvas instance => null;

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		protected virtual void OnDestroy()
		{
		}

		public static IEnumerator MoveMeToScene(HeaderCanvas obj)
		{
			return null;
		}

		public static bool DoMoveMeToScene(HeaderCanvas obj)
		{
			return default(bool);
		}

		public static MenuPopup GetMenuPopup()
		{
			return null;
		}

		public static void SetMenuPopup(MenuPopup menuPopup)
		{
		}

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		public void Reload()
		{
		}

		public void ResetPresentAndMenuBg()
		{
		}

		public void ResetCamera()
		{
		}

		private IEnumerator ResetCameraCoroutine()
		{
			return null;
		}

		public void ShowCaption(string title, CaptionCanvas.IconType iconType, bool ignoreSameTitle = false)
		{
		}

		public void HideCaption()
		{
		}

		private void HandleRequest()
		{
		}

		public void SetCaptionAutoAnimationState(bool v)
		{
		}

		public void ShowPresentAndMenuButton()
		{
		}

		public void HidePresentAndMenuButton()
		{
		}

		public void SlideIn(float duration = 0.3f, Direction itemMenuDirection = Direction.Vertical, bool needSlideInCaption = true)
		{
		}

		public void SlideOut(float duration = 0.3f, Direction itemMenuDirection = Direction.Vertical)
		{
		}

		private void MoveTo(RectTransform targetRectTransform, float startY, float endY, float duration)
		{
		}

		private void MoveWithScale(Sequence mainSeq, RectTransform targetRectTransform, float startY, float endY, float duration, float endScale)
		{
		}

		public void SlideInFade(float duration = 0.3f)
		{
		}

		public void SlideOutFade(float duration = 0.3f)
		{
		}

		public void PresentAndMenuButtonSlideIn(float duration = 0.3f, Direction itemMenuDirection = Direction.Horizontal)
		{
		}

		public void PresentAndMenuButtonSlideOut(float duration = 0.3f, Direction itemMenuDirection = Direction.Horizontal)
		{
		}

		private void SetPresentAndMenuButtonInteractable(bool interactable)
		{
		}

		public void SetInteractableButtons(bool interactable)
		{
		}

		public void ResetPressedState()
		{
		}

		public void ResetMenuButtonSelectedImage()
		{
		}

		private void InitCaptionRectTrans(RectTransform rectTrans)
		{
		}
	}
}
