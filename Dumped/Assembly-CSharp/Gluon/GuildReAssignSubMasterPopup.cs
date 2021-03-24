/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildReAssignSubMasterPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public Transform memberCellParent;
		private GuildMemberTableViewCell cell;
		private GuildModel.MemberInfo data;
		private GuildModel.MemberInfo subMasterData;
		private Action onAnyActionDone;
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildReAssignSubMasterPopup";
	
		// Nested types
		[CompilerGenerated]
		private struct _OnAssignAsSubMasterButtonPressed_d__8 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildReAssignSubMasterPopup __4__this;
			private TaskAwaiter<GuildUpdateGuildPositionTypeResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public GuildReAssignSubMasterPopup();
	
		// Methods
		public static GuildReAssignSubMasterPopup Create(GuildModel.MemberInfo data, GuildModel.MemberInfo currentSubMasterData, Action onAnyActionDone);
		protected override void Start();
		public async void OnAssignAsSubMasterButtonPressed();
		[CompilerGenerated]
		private void _OnAssignAsSubMasterButtonPressed_b__8_0();
	}
}
