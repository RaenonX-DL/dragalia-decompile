/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortPullMenu : MonoBehaviour
	{
		// Fields
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
		public UnityEvent onStoreHouseButtonPressed;
		public UnityEvent onViewModeButtonPressed;
		public UnityEvent onFortDetailButtonPressed;
		public UnityEvent onInvisibleButtonPressed;
		private RuntimeAnimatorController viewModeButtonAnimatorController;
		private RuntimeAnimatorController fortDetailButtonAnimatorController;
		private RuntimeAnimatorController invisibleButtonAnimatorController;
	
		// Properties
		public float pullMenuMoveDuration { get; }
	
		// Constructors
		public FortPullMenu();
	
		// Methods
		private void Awake();
		public void OnPullMenuButtonPressed();
		public void SlideIn();
		public void SlideOut();
		public void OnSlideInEnd();
		public void OnSlideOutEnd();
		public void OnStoreHouseButtonPressed();
		public void OnViewModeButtonPressed();
		private void UpdateViewModeIcon();
		public void OnFortDetailButtonPressed();
		public void OnInvisibleButtonPressed();
		public void SetAllButtonAnimatorController(RuntimeAnimatorController animatorController, bool isInteractable, bool isBackup = false);
		public void SetBackAllButtonAnimatorController(bool isInteractable = true);
		private RuntimeAnimatorController SetButtonAnimatorController(Button button, bool isInteractable, RuntimeAnimatorController animatorController);
		[CompilerGenerated]
		private void _Awake_b__18_0(bool isReverseAnimation);
	}
}
