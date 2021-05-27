/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoreHouseDialogController : PopupBase
	{
		// Fields
		[SerializeField]
		private TabViewBase tabView;
		[SerializeField]
		private UnityEngine.UI.Text dialogTextTitle;
		[SerializeField]
		private UnityEngine.UI.Text closelButtonLabel;
		[CompilerGenerated]
		private Canvas _canvas_k__BackingField;
		[CompilerGenerated]
		private GameObject _fortRoot_k__BackingField;
	
		// Properties
		public Canvas canvas { [CompilerGenerated] get; [CompilerGenerated] set; }
		public GameObject fortRoot { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static ExecuteEvents.EventFunction<FortUIEventInterface> __9__14_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnFalicitySelectCofirm_b__14_0(FortUIEventInterface reciever, BaseEventData eventData);
		}
	
		// Constructors
		public StoreHouseDialogController();
	
		// Methods
		private void Awake();
		protected override void Start();
		public void OnCloseButtonPressd();
		public void OnFalicitySelectCofirm(Facility facility);
		[CompilerGenerated]
		private void _Start_b__12_0(int curIndex, int previousIndex);
	}
}
