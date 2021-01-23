/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultFriendApplyPage : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Transform panelParent;
		public Transform rebattlePart;
		public GameObject rebattleGOToClose;
		public GameObject originalCell;
		public Transform contentParent;
		public UnityEngine.UI.Text rebattleCountDownText;
		private List<QRFriendApplyCell> createdCellList;
		private DateTime rebattleStartTime;
		private UnityAction onOpenUnitDetail;
		private UnityAction onCloseUnitDetail;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public QuestResultModel.FriendApplyModel model;
			public QuestResultFriendApplyPage __4__this;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _InitByData_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _UpdateRebattle_d__13 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestResultFriendApplyPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdateRebattle_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestResultFriendApplyPage();
	
		// Methods
		private void Awake();
		public void InitByData();
		private void CreateFirstMetRewardDialog();
		[IteratorStateMachine]
		private IEnumerator UpdateRebattle();
		private void CloseRebattleWindow();
		public void OnRebattlePressed();
		public void OnRebattleCancelPressed();
		private void OnOpenDetail();
		private void OnCloseDetail();
		public void SetUnitDetailModelOnCreated(UnityAction action);
		public void SetUnitDetailModelBackButtonOnClick(UnityAction action);
	}
}
