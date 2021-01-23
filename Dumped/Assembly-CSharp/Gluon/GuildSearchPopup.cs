/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildSearchPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public TabViewBase tabView;
		[Header]
		[SerializeField]
		public GuildInfoTableViewController searchList;
		[Header]
		[SerializeField]
		public Transform appliedCellTransform;
		public GameObject noAppliedContent;
		public GameObject appliedContent;
		[Header]
		[SerializeField]
		public InputField nameInput;
		public InputField idInput;
		[Header]
		[SerializeField]
		public GameObject okButtonGO;
		public Button okButton;
		private GuildInfoTableViewCell appliedCell;
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildSearchPopup";
		private List<GuildInfoCellData> cellDataList;
		private GuildInfoCellData.FilterOption filter;
		private TabType currentTab;
	
		// Nested types
		private enum TabType
		{
			Recommended = 0,
			Name = 1,
			ID = 2,
			Applied = 3
		}
	
		[CompilerGenerated]
		private struct _CreateModule_d__15 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			private TaskAwaiter<GuildSearchAutoSearchResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<int, int> __9__16_0;
			public static Func<int, int> __9__16_1;
			public static Func<int, int> __9__16_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _RequestRecommendedList_b__16_0(int v);
			internal int _RequestRecommendedList_b__16_1(int v);
			internal int _RequestRecommendedList_b__16_2(int v);
		}
	
		[CompilerGenerated]
		private struct _RequestRecommendedList_d__16 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<GuildSearchAutoSearchResponse> __t__builder;
			public GuildInfoCellData.FilterOption filter;
			private TaskAwaiter<GuildSearchAutoSearchResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _SearchByName_d__21 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public string name;
			public GuildSearchPopup __4__this;
			private TaskAwaiter<GuildSearchNameSearchResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _SearchById_d__22 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public int guildId;
			public GuildSearchPopup __4__this;
			private TaskAwaiter<GuildSearchIdSearchResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _UpdateRecommendedList_d__23 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildSearchPopup __4__this;
			private TaskAwaiter<GuildSearchAutoSearchResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public GuildSearchPopup __4__this;
			public GuildInfoCellData data;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _OnCellPressed_b__0();
		}
	
		[CompilerGenerated]
		private struct _Apply_d__25 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildInfoCellData data;
			public int guildId;
			public Action onApplyDone;
			public GuildSearchPopup __4__this;
			private TaskAwaiter<GuildJoinResponse> __u__1;
			private TaskAwaiter<GuildJoinRequestResponse> __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct __OnCancelApplyButtonPressed_b__27_0_d : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildSearchPopup __4__this;
			private TaskAwaiter<GuildJoinRequestCancelResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public GuildSearchPopup();
	
		// Methods
		public static async void CreateModule();
		private static async Task<GuildSearchAutoSearchResponse> RequestRecommendedList(GuildInfoCellData.FilterOption filter);
		protected override void Start();
		private int GetValidGuildId(string text);
		public void OnTabChanged(int tabIndex, int prevTabIndex);
		public void OnSearchButtonPressed();
		private async void SearchByName(string name);
		private async void SearchById(int guildId);
		private async void UpdateRecommendedList();
		public void OnCellPressed(GuildInfoCellData data);
		private async void Apply(int guildId, GuildInfoCellData data, Action onApplyDone = null);
		private void UpdateAppliedData();
		public void OnCancelApplyButtonPressed();
		[CompilerGenerated]
		private void _Start_b__17_0(GuildInfoCellData.FilterOption filter, Action<List<GuildInfoCellData>> onRetrived);
		[CompilerGenerated]
		private void _Start_b__17_1(string inputText);
		[CompilerGenerated]
		private void _Start_b__17_2(string inputText);
		[CompilerGenerated]
		private async void _OnCancelApplyButtonPressed_b__27_0();
	}
}
