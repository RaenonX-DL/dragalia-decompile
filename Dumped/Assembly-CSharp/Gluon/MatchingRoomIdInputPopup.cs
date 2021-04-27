/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingRoomIdInputPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private InputFrame inputFrame;
		[SerializeField]
		private UnityEngine.UI.Text searchButtonText;
		[SerializeField]
		private Button searchButton;
		private QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation;
		private const int MaxRommInputCount = 7;
		private Action<int, QuestAutoTransitionUtil.GuestEnterRoomFromType> goPrepareScene;
		private bool searchPrevRoom;
		private static int prevRoomId;
		private static RoomList prevRoomData;
		private static int prevRoomIsFriend;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _ShowPrevRoomPopup_d__13 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MatchingRoomIdInputPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowPrevRoomPopup_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _PopupNothingRoom_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public MatchingRoomIdInputPopup __4__this;
			public MatchingGetRoomNameResponse res;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _OnMatchingGetRoomNameRequestSuccess_b__0(bool isRecoveredStamina);
			internal void _OnMatchingGetRoomNameRequestSuccess_b__1();
		}
	
		// Constructors
		public MatchingRoomIdInputPopup();
	
		// Methods
		public static void ClearPrevRoomData();
		public void Initialize(QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation, Action<int, QuestAutoTransitionUtil.GuestEnterRoomFromType> goPrepareScene, bool searchPrevRoom);
		protected override void Start();
		[IteratorStateMachine]
		private IEnumerator ShowPrevRoomPopup();
		public void OnClearButtonPressed();
		public void OnDeleteButtonPressed();
		public void OnSearchButtonPressed();
		public void OnCancelButtonPressed();
		private void OnNumberButtonPressed(List<string> num);
		private void ServerRoomNameGat(int roomId);
		private void OnMatchingGetRoomNameRequestError(ErrorType errorType, int resultCode);
		public static void PopupNothingRoom();
		private void OnMatchingGetRoomNameRequestSuccess(MatchingGetRoomNameResponse res);
		private void GoQuestPrepareScene(int roomQuestId);
		public static void CheckJoinConditions(GameObject gameObject, int questId, Action<bool> onSuccess);
		[CompilerGenerated]
		private void _ShowPrevRoomPopup_b__13_0();
	}
}
