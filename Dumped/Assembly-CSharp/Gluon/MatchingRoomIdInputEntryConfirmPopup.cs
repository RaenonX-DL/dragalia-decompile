/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
		private Action<int> goPrepareScene;
		private QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation;
		private QuestRoomList cell;
		private PartySwitchPopup switchPopup;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public QuestLimitedConfirmPopup popup;
			public MatchingRoomIdInputEntryConfirmPopup __4__this;
			public UnityAction __9__3;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _EnterRoom_b__2();
			internal void _EnterRoom_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public CommonPopup popup;
			public MatchingRoomIdInputEntryConfirmPopup __4__this;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _PopupNothingRoom_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public CommonPopup popup;
			public MatchingRoomIdInputEntryConfirmPopup __4__this;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _PopupLimitRoomCreate_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public CommonPopup popup;
			public MatchingRoomIdInputEntryConfirmPopup __4__this;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _PopupInvalidCompatibleId_b__0();
		}
	
		// Constructors
		public MatchingRoomIdInputEntryConfirmPopup();
	
		// Methods
		public static MatchingRoomIdInputEntryConfirmPopup Create(QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation, RoomList roomList, bool isFriend, Action onEnterRoom, Action<int> goPrepareScene, Transform parentTransform = null);
		private void SetupWithData(RoomList roomList, bool isFriend);
		public void OnEnterButtonPressed();
		private void EnterRoom();
		protected override void OnDestroy();
		public void OnMatchingServiceStateChanged(MatchingService.StateType state);
		private void ErrorTypeCheck(MultiPlayError error);
		private void PopupNothingRoom();
		private void PopupLimitRoomCreate();
		private void PopupInvalidCompatibleId();
		[CompilerGenerated]
		private void _OnEnterButtonPressed_b__10_0();
		[CompilerGenerated]
		private void _EnterRoom_b__11_0();
		[CompilerGenerated]
		private void _EnterRoom_b__11_1();
		[CompilerGenerated]
		private void _EnterRoom_b__11_4();
	}
}
