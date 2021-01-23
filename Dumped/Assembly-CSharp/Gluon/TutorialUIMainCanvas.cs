/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TutorialUIMainCanvas : MonoBehaviour
	{
		// Fields
		public GameObject pointer;
		public GameObject blackTouchGuard;
		public Canvas touchGuardCanvas;
		public GameObject touchGuradExceptFooter;
		public GameObject touchGuradExceptBottom;
		public GameObject nextActionButtonObj;
		private Action buttonCallBack;
		private int oldTouchGuardCanvasSortingOrder;
	
		// Constructors
		public TutorialUIMainCanvas();
	
		// Methods
		public static TutorialUIMainCanvas Create();
		private void Awake();
		public void HidePointer();
		public void ShowPointer();
		public void SetNextActionButton(Action callBack);
		public void DesableNextActionButton();
		public void SetTouchGuardCanvasSortingOrder(int value);
		public void ResetTouchGuardCanvasSortingOrder();
		public void OnNextActionButtonPressed();
	}
}
