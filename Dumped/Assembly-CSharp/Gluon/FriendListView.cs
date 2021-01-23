/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FriendListView : FriendPanelBase
	{
		// Fields
		private static Action onHttpDone;
		public Transform frameParent;
		public RectTransform referenceRect;
		[SerializeField]
		private FriendListController listController;
		[SerializeField]
		private Button allDenyButton;
		[SerializeField]
		private UnityEngine.UI.Text friendNumText;
		private List<FriendListCellData> cellDataList;
		private const int friendListUnmatchedErrorCode = 7005;
		private const int friendRequestErrorCode = 7012;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public FriendListView __4__this;
			public FriendListCellData data;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _CreateConfirmFriendRemovePopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public FriendListView __4__this;
			public FriendListCellData data;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _RequestFriendRemove_b__0(FriendDeleteResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public FriendListView __4__this;
			public FriendListCellData data;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _RequestFriendCancel_b__0(FriendRequestCancelResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public FriendListView __4__this;
			public FriendListCellData data;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _RequestFriendReplyApproval_b__0(FriendReplyResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public FriendListView __4__this;
			public FriendListCellData data;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _RequestFriendReplyDeny_b__0(FriendReplyResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public GuildInfoCellData data;
			public GuildApplyConfirmPopup popup;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _SearchById_b__1();
			internal void _SearchById_b__2();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<GuildSearchGetGuildDetailResponse> __9__22_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _SearchById_b__22_0(GuildSearchGetGuildDetailResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public Action onApplyDone;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _Apply_b__0(GuildJoinResponse res);
			internal void _Apply_b__1(GuildJoinRequestResponse res);
		}
	
		// Constructors
		public FriendListView();
	
		// Methods
		public static FriendListView Create(Transform parent, FriendScene scene);
		private void Start();
		public override void PlayExitAnimation(Action onFinished);
		private void SetFriendList();
		public void OnFriendAllDenyButtonPressed();
		private void CreateConfirmFriendRemovePopup(FriendListCellData data);
		private void RequestFriendRemove(FriendListCellData data);
		private void RequestFriendCancel(FriendListCellData data);
		private void RequestFriendReplyApproval(FriendListCellData data);
		private void RequestFriendReplyDeny(FriendListCellData data);
		private void RequestFriendAllDeny();
		public static void OnGuildInviteButton(FriendListCellData data);
		public static void OnGuildJoinButton(FriendListCellData data);
		private static void SearchById(int guildId);
		private static void Apply(int guildId, GuildInfoCellData data, Action onApplyDone = null);
		public static void RequestForEntryHttp(Action onHttpDoneCallback);
		public static void OnEntryHttpSuccess();
		public void OnSortButtonPressed();
		public void OnError(ErrorType errorType, int resultCode);
		private void ReloadPanelList();
		[CompilerGenerated]
		private void _RequestFriendAllDeny_b__19_0(FriendAllReplyDenyResponse res);
	}
}
