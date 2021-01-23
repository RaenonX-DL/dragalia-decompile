/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingRoomIdInputEntryConfirmPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public Transform cellFrame;
		private const string matchingRoomListCellPrefabPath = "UI/Popup/MyPage/MatchingRoomListCell";
		private RoomListData roomListData;
		private Action onEnterRoom;
		private QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation;
		private QuestRoomList cell;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public QuestLimitedElementConfirmPopup popup;
			public MatchingRoomIdInputEntryConfirmPopup __4__this;
			public UnityAction __9__3;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _OnEnterButtonPressed_b__2();
			internal void _OnEnterButtonPressed_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _PopupNothingRoom_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _PopupLimitRoomCreate_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _PopupInvalidCompatibleId_b__0();
		}
	
		// Constructors
		public MatchingRoomIdInputEntryConfirmPopup();
	
		// Methods
		public static MatchingRoomIdInputEntryConfirmPopup Create(QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation, RoomList roomList, bool isFriend, Action onEnterRoom);
		private void SetupWithData(RoomList roomList, bool isFriend);
		public void OnEnterButtonPressed();
		protected override void OnDestroy();
		public void OnMatchingServiceStateChanged(MatchingService.StateType state);
		private void ErrorTypeCheck(MultiPlayError error);
		private void PopupNothingRoom();
		private void PopupLimitRoomCreate();
		private void PopupInvalidCompatibleId();
		[CompilerGenerated]
		private void _OnEnterButtonPressed_b__8_0();
		[CompilerGenerated]
		private void _OnEnterButtonPressed_b__8_1();
		[CompilerGenerated]
		private void _OnEnterButtonPressed_b__8_4();
	}
}
