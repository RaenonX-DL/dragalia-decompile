/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyCrestSetPopupCell : MonoBehaviour
	{
		// Fields
		public UnityEngine.UI.Text setName;
		public CommonUnitIcon[] commonUnitIcons;
		public GameObject[] emptyIconObjects;
		public Image[] unionIcons;
		public Action<int> selectCallBack;
		public Action<int> registCallBack;
		public GameObject detailButtonObject;
		private int setIndex;
		private bool isSelectableCell;
		private bool isEquipData;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public PartyCrestSetNameEditPopup popup;
			public PartyCrestSetPopupCell __4__this;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _OnEditNameButtonPressed_b__0();
			internal void _OnEditNameButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public PartyCrestSetDetailPopup popup;
			public PartyCrestSetPopupCell __4__this;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _OnDetailButtonPressed_b__0();
			internal void _OnDetailButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public PartyCrestSetRegistPopup popup;
			public PartyCrestSetPopupCell __4__this;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _OnRegistButtonPressed_b__0();
			internal void _OnRegistButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private struct _SendCrestSetName_d__16 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public int index;
			public string name;
			public PartyCrestSetPopupCell __4__this;
			private TaskAwaiter<AbilityCrestUpdateAbilityCrestSetNameResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public PartyCrestSetPopupCell();
	
		// Methods
		public void InitCellByEquipData(int index);
		public void UpdateCell(int index, bool canSelect = true);
		public void OnEditNameButtonPressed();
		public void OnDetailButtonPressed();
		public void OnRegistButtonPressed();
		public void OnSelectButtonPressed();
		private async void SendCrestSetName(int index, string name);
		public void OnCrestIconPressed(int tag);
	}
}
