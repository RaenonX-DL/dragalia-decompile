/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FriendModel
	{
		// Fields
		public const int inputIdLength = 11;
		public const int showLimitDay = 10;
		public int friendNum;
		public UnityAction<string, Footer.MenuTab> onFooterButtonPressed;
		public UnityAction<UnityAction> changeSceneCallback;
		private readonly int searchListUpdateIntervalSec;
		private long _searchListLastUpdateUnixTime;
		public int currentSupportCharacterID;
		private ulong currentSupportDragonKeyID;
		private ulong currentSupportWeaponBodyID;
		private ulong currentSupportAmuletID1;
		private ulong currentSupportAmuletID2;
		private ulong currentSupportAmuletID3;
		private ulong currentSupportAmuletID4;
		private ulong currentSupportAmuletID5;
		private static FriendModel instance;
		public PanelType currentPanel;
		public PanelType nextPanel;
		public const string prefabPath = "Prefabs/OutGame/Friend/";
	
		// Properties
		public long searchListLastUpdateUnixTime { get; set; }
		public static FriendModel Instance { get; }
	
		// Nested types
		public enum PanelType
		{
			None = 0,
			Top = 1,
			FriendList = 2,
			FriendSearch = 3,
			ApplyingList = 4,
			ApprovalWaitList = 5,
			SupportSetting = 6
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public FriendModel __4__this;
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _RequestFriendList_b__0(FriendFriendListResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _RequestAppryingList_b__0(FriendRequestListResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public FriendModel __4__this;
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal void _RequestApprovalWaitList_b__0(FriendApplyListResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0
		{
			// Fields
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass35_0();
	
			// Methods
			internal void _RequestUpdateResetNewFriend_b__0(UpdateResetNewResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0
		{
			// Fields
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass36_0();
	
			// Methods
			internal void _RequestUpdateResetNewFriendApply_b__0(UpdateResetNewResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _RequestSetSupportChara_b__0(FriendSetSupportCharaResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public FriendModel __4__this;
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _RequestGetSupportChara_b__0(FriendGetSupportCharaResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0
		{
			// Fields
			public FriendModel __4__this;
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _RequestRecommendedList_b__0(FriendAutoSearchResponse res);
		}
	
		// Constructors
		private FriendModel();
		static FriendModel();
	
		// Methods
		public static int GetNewFriendCount();
		public static int GetNewApprovalWaitCount();
		public static bool IsNewApplyFriend(ulong viewer_id);
		public static bool IsNewFriend(ulong viewer_id);
		public static void DeleteInstance();
		public void RequestFriendList(Action successCallback);
		public void RequestAppryingList(Action successCallback);
		public void RequestApprovalWaitList(Action successCallback);
		public void RequestUpdateResetNewFriend(ulong[] friendIds, Action successCallback);
		public void RequestUpdateResetNewFriendApply(Action successCallback);
		public void RequestSetSupportChara(Action successCallback);
		public void RequestGetSupportChara(Action successCallback);
		public void RequestRecommendedList(Action successCallback);
		public void OnError(ErrorType errorType, int resultCode);
		public string GetFriendNumText();
		public ulong GetEquipId(FriendSupportSettingView.Type type);
		public void SetEquipId(FriendSupportSettingView.Type type, ulong value);
		public void SetAmuletId(int index, ulong value);
		private void RestWeaponSlot(ulong value);
	}
}
