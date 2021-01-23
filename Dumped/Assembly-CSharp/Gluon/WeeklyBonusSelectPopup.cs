/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UniRx.Async;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class WeeklyBonusSelectPopup : PopupBase
	{
		// Fields
		public CommonIcon icon;
		public GameObject prevWeekWarningGO;
		private const string prefabPath = "Prefabs/OutGame/QuestResult/Popup/WeeklyBonusSelectPopup";
		private const string multiplePrefabPath = "Prefabs/OutGame/QuestResult/Popup/WeeklyBonusMultipleSelectPopup";
		protected int count;
		private int eventId;
		private int forWeekDate;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public bool done;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _OnRedeemButtonPressed_b__0();
			internal bool _OnRedeemButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private struct _OnRedeemButtonPressed_d__10 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public WeeklyBonusSelectPopup __4__this;
			private __c__DisplayClass10_0 __8__1;
			private TaskAwaiter<DungeonReceiveQuestBonusResponse> __u__1;
			private UniTask.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _OnCancelButtonPressed_d__11 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public WeeklyBonusSelectPopup __4__this;
			private TaskAwaiter<DungeonReceiveQuestBonusResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public WeeklyBonusSelectPopup();
	
		// Methods
		public static WeeklyBonusSelectPopup Create(int count, int eventId, int forWeekDate);
		protected override void Start();
		protected virtual int GetReceiveCount();
		public async void OnRedeemButtonPressed();
		public async void OnCancelButtonPressed();
	}
}
