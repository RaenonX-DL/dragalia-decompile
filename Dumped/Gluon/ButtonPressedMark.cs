using UnityEngine;

namespace Gluon
{
	public class ButtonPressedMark : MonoBehaviour
	{
		public enum Type
		{
			Yes,
			No
		}

		public RectTransform yesLeftRectTransform;

		public RectTransform yesRightRectTransform;

		public RectTransform noLeftRectTransform;

		public RectTransform noRightRectTransform;

		public CanvasGroup canvasGroup;

		public bool dontDestroyOnCompleted;

		private Transform oldParent;

		public bool ignoreTimeScale;

		public Type type;

		public Vector3 initialRootPos;

		public Vector3 initialYesLeftPos;

		public Vector3 initialYesRightPos;

		public Vector3 initialNoLeftPos;

		public Vector3 initialNoRightPos;

		public static void Decided(GameObject buttonObject)
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void OnDecided()
		{
		}

		private void OnDecidedYes()
		{
		}

		private void OnDecidedNo()
		{
		}

		private void OnBeginAnimation()
		{
		}

		private void OnCompleted()
		{
		}
	}
}
