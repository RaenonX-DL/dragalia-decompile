/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public int tutorialStep;
			public BuildDialogController __4__this;
	
			// Constructors
			public __c__DisplayClass7_0();
	
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
			public static ExecuteEvents.EventFunction<FortUIEventInterface> __9__7_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnFalicitySelectCofirm_b__7_2(FortUIEventInterface reciever, BaseEventData eventData);
		}
	
		// Constructors
		public BuildDialogController();
	
		// Methods
		private void Awake();
		protected override void Start();
		public void OnCloseButtonTouched();
		public void OnFalicitySelectCofirm(Facility facility, FortModel.BuildFacilityResult buildResult);
		[CompilerGenerated]
		private void _Start_b__5_0(int curIndex, int previousIndex);
	}
}
