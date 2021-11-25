using System;
using UnityEngine;

namespace Gluon
{
	public class TutorialUIMainCanvas : MonoBehaviour
	{
		public GameObject pointer;

		public GameObject blackTouchGuard;

		public Canvas touchGuardCanvas;

		public GameObject touchGuradExceptFooter;

		public GameObject touchGuradExceptBottom;

		public GameObject nextActionButtonObj;

		private Action buttonCallBack;

		private int oldTouchGuardCanvasSortingOrder;

		public static TutorialUIMainCanvas Create()
		{
			return null;
		}

		private void Awake()
		{
		}

		public void HidePointer()
		{
		}

		public void ShowPointer()
		{
		}

		public void SetNextActionButton(Action callBack)
		{
		}

		public void DesableNextActionButton()
		{
		}

		public void SetTouchGuardCanvasSortingOrder(int value)
		{
		}

		public void ResetTouchGuardCanvasSortingOrder()
		{
		}

		public void OnNextActionButtonPressed()
		{
		}
	}
}
