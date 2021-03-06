﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ClearPartyEquipSampleListPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text questName;
		public ClearPartyEquipSampleListController equipSampleListController;
		[HideInInspector]
		public SceneBase scene;
		private int targetQuestId;
		private int[] targetCharaIds;
		private int questGroupId;
		private int[] questIds;
		private int pageIndex;
		private float scrollPos;
	
		// Nested types
		[CompilerGenerated]
		private struct _LoadPartyEquipSampleDatas_d__11 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ClearPartyEquipSampleListPopup __4__this;
			private TouchGuardObject _touchGuardObj_5__2;
			private TaskAwaiter<QuestSearchQuestClearPartyResponse> __u__1;
			private UniTask.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public OtherUserClearPartyListPopup popup;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _OnBackButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public ClearPartyEquipSampleListPopup __4__this;
			public ClearPartyEquipSampleListCellData cellData;
	
			// Constructors
			public __c__DisplayClass15_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass15_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass15_1();
	
			// Methods
			internal void _OnSetButtonPressed_b__0();
			internal void _OnSetButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public PartyChangePopup popup;
			public ClearPartyEquipSampleListPopup __4__this;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _ShowPartyChangePopup_b__0(int partyIndex, PartyList partyList);
			internal void _ShowPartyChangePopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public Action completePopAction;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _UpdatePartyData_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_1
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass17_1();
	
			// Methods
			internal void _UpdatePartyData_b__3();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__17_0;
			public static Action<ErrorType, int> __9__17_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _UpdatePartyData_b__17_0();
			internal void _UpdatePartyData_b__17_2(ErrorType error, int resultCode);
		}
	
		[CompilerGenerated]
		private struct _UpdatePartyData_d__17 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public int partyIndex;
			public PartyList partyList;
			private __c__DisplayClass17_0 __8__1;
			private TaskAwaiter<PartySetPartySettingResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public ClearPartyEquipSampleListPopup();
	
		// Methods
		public static ClearPartyEquipSampleListPopup Create(SceneBase scene);
		public void InitPopup(int questId, int[] charaIds);
		private async void LoadPartyEquipSampleDatas();
		public void SetPrevPopupData(int questGroupId, int[] questIds, int pageIndex, float scrollPos);
		public void OnBackButtonPressed();
		public void OnReloadButtonPressed();
		private void OnSetButtonPressed(ClearPartyEquipSampleListCellData cellData);
		private void ShowPartyChangePopup(int sampleDataIndex);
		private async void UpdatePartyData(int partyIndex, PartyList partyList);
		private bool IsShowUnitEmptyPopup(ClearPartyEquipSampleListCellData cellData);
	}
}
