/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BuildDialogController : PopupBase
	{
		// Fields
		public TabViewBase tabView;
		[SerializeField]
		private UnityEngine.UI.Text dialogTextTitle;
		[SerializeField]
		private Button closeButton;
		private FortScene fortScene;
		private List<FacilitySelectCtrl> facilitySelectCtrlList;
		private static List<string> buildFacilityTabNameList;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public int tutorialStep;
			public BuildDialogController __4__this;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _OnFalicitySelectCofirm_b__1(Facility selectedFacility);
			internal void _OnFalicitySelectCofirm_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static ExecuteEvents.EventFunction<FortUIEventInterface> __9__9_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnFalicitySelectCofirm_b__9_2(FortUIEventInterface reciever, BaseEventData eventData);
		}
	
		// Constructors
		public BuildDialogController();
	
		// Methods
		private void Awake();
		protected override void Start();
		public void OnCloseButtonTouched();
		public void OnFalicitySelectCofirm(Facility facility, FortModel.BuildFacilityResult buildResult);
		public static void ResetTabSetting();
		private void RegisterTabNameList();
		[CompilerGenerated]
		private void _Start_b__7_0(int curIndex, int previousIndex);
	}
}
