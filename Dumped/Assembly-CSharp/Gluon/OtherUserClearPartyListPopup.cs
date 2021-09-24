/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OtherUserClearPartyListPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text questName;
		public TabBase questDifficultyTab;
		public OtherUserClearPartyListController userClearPartyListController;
		public TabBase listPageTab;
		[HideInInspector]
		public SceneBase scene;
		private int questGroupId;
		private int[] questIds;
		private int currentQuestId;
		private int currentPageIndex;
		private TouchGuardObject buttonPressTouchGuardObject;
	
		// Nested types
		[CompilerGenerated]
		private struct _SpecifOpenPage_d__14 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public OtherUserClearPartyListPopup __4__this;
			public int questId;
			public int pageIndex;
			public float scrollPos;
			private TouchGuardObject _touchGuardObj_5__2;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _DifficultyTabSelected_d__15 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public OtherUserClearPartyListPopup __4__this;
			public int index;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _PageTabSelected_d__16 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public OtherUserClearPartyListPopup __4__this;
			public int index;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public OtherUserClearPartyListPopup __4__this;
			public int partySwitchIndex;
			public OtherUserClearPartyListCellData data;
			public DragEventScrollRect scrollRect;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _OnListCellButtonPressed_b__0();
		}
	
		// Constructors
		public OtherUserClearPartyListPopup();
	
		// Methods
		public static OtherUserClearPartyListPopup Create(SceneBase scene);
		public void InitPopup(int questGroupId, int[] questIds, bool isLoadList = true);
		private void InitializeSinglePlay();
		private void InitializeMultiPlay();
		public async void SpecifOpenPage(int questId, int pageIndex, float scrollPos);
		private async void DifficultyTabSelected(int index);
		private async void PageTabSelected(int index);
		private void OnListCellButtonPressed(OtherUserClearPartyListCellData data, int partySwitchIndex);
	}
}
