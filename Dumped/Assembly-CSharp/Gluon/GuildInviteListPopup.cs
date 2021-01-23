/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildInviteListPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		private GuildInfoTableViewController searchList;
		[SerializeField]
		private Button ArrDenyButton;
		private List<GuildInfoCellData> cellDataList;
		private AtgenGuildInviteParamsList[] guildInviteParamsList;
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildInviteListPopup";
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__5_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Create_b__5_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public GuildInfoCellData data;
			public GuildInviteListPopup __4__this;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _OnCellPressed_b__0(FriendGetSupportCharaDetailResponse responce);
			internal void _OnCellPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public Action onFinished;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _RequestGuildList_b__0(GuildInviteGetGuildInviteReceiveDataResponse res);
		}
	
		// Constructors
		public GuildInviteListPopup();
	
		// Methods
		public static void Create();
		public static GuildInviteListPopup Create(DataManager.GameData<GuildInviteReceiveList> dataList);
		protected override void Start();
		public void OnCellPressed(GuildInfoCellData data);
		private static void RequestGuildList(Action onFinished);
		private static AtgenGuildInviteParamsList[] GetAtgenGuildInviteParamsList(DataManager.GameData<GuildInviteReceiveList> dataList);
		private void UpdateList();
		public void OnPressAllDenyButton();
		private void RejectAction(GuildInfoCellData cellData);
		private void OnRejectRequest(GuildInfoCellData data, Action onFinished);
		[CompilerGenerated]
		private void _OnPressAllDenyButton_b__12_0(GuildInviteInviteReplyAllDenyResponse res);
		[CompilerGenerated]
		private void _OnPressAllDenyButton_b__12_1();
		[CompilerGenerated]
		private void _OnPressAllDenyButton_b__12_2();
		[CompilerGenerated]
		private void _RejectAction_b__13_0();
		[CompilerGenerated]
		private void _OnRejectRequest_b__14_0(GuildInviteInviteReplyResponse res);
		[CompilerGenerated]
		private void _OnRejectRequest_b__14_1();
		[CompilerGenerated]
		private void _OnRejectRequest_b__14_2();
	}
}
