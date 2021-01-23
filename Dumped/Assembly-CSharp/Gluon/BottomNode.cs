/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BottomNode : MonoBehaviour
	{
		// Fields
		public GameObject touchEventNode;
		public GameObject facilityLevelupButton;
		public Button levelUpButton;
		public UnityEngine.UI.Text levelUpMaxText;
		public Color leveUpButtonDisableColor;
		public GameObject facilityRelocationButton;
		public GameObject facilityStoreButton;
		public GameObject facilityInfoButton;
		public GameObject stopButton;
		public GameObject completeAtOnceButton;
		public AnimationUIGroup facilityNameGroup;
		public UnityEngine.UI.Text facilityText;
		private FacilityViewController curFacilityTextVc;
		private RectTransform facilityButtonsParentRect;
		private float facilityButtonsParentRectOriginalWidth;
		private FortViewController fortViewCtrl;
		public AnimationUIGroup moveGroup;
		private bool isSlideIn;
	
		// Constructors
		public BottomNode();
	
		// Methods
		private void Start();
		public void OnInit(FortViewController fortViewCtrl);
		public bool IsSetFacilityText(FacilityViewController facilityVc);
		public void OnSelectFacility(FacilityViewController facilityViewController);
		private string GetFacilityText(Facility facility);
		public void SlideOut();
		public void SlideIn(bool isButtonDisable = false);
		private void InteractableButton(bool isInteractable);
		private void UpdateLevelUpInteractable();
		[CompilerGenerated]
		private void _Start_b__18_0(bool isReverse);
		[CompilerGenerated]
		private void _Start_b__18_1(bool isReverse);
	}
}
