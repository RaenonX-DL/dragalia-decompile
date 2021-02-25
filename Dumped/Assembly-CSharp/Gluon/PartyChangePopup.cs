/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyChangePopup : CommonPopup
	{
		// Fields
		public TabBase partyGroupTab;
		public Transform listParentTransform;
		public GameObject originCell;
		private PartyChangePopupCell[] cells;
		public Action<int, bool> partyChangeAction;
		public Action<int, bool> partyCopyAction;
		private int nowGroupIndex;
		private int nowPartyIndex;
		private int selectGroupIndex;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public CommonPopup popup;
			public PartyChangePopup __4__this;
			public int partyIndex;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _CopyButtonAction_b__0();
			internal void _CopyButtonAction_b__1();
		}
	
		// Constructors
		public PartyChangePopup();
	
		// Methods
		public static PartyChangePopup Create();
		public void InitPopup(int questId, int partyGroupIndex = -1, int partyIndex = -1, bool isHideCopyButton = false);
		public override void StartShowAnimation(UnityEvent onCompleted = null);
		private void OnSelectedGroupTab(int index);
		private void ReloadCell();
		private void ChangeButtonAction(int partyIndex);
		private void CopyButtonAction(int partyIndex);
		[CompilerGenerated]
		private void _StartShowAnimation_b__11_0();
	}
}
