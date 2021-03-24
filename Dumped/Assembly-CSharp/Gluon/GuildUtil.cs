/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class GuildUtil
	{
		// Fields
		private const string createOrJoinPopupPath = "GuildCreateOrJoinPopup";
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__1_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _EntryToGuildScene_b__1_0();
		}
	
		[CompilerGenerated]
		private struct _EntryToGuildScene_d__1 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public UnityAction onClosePopup;
			public bool onErrorReturnToTitle;
			private TaskAwaiter<GuildIndexResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Methods
		public static async void EntryToGuildScene(bool onErrorReturnToTitle = false, UnityAction onClosePopup = null);
		public static void ReturnToMyPage();
		public static void GoGuildSceneAsync();
		public static void SetEmblemIcon(RawImage image, int emblemId, IconLoader.Size size = IconLoader.Size.M);
		public static bool HasMemberApprovalAuthority(GuildModel.Occupation occupation);
		public static bool HasMemberAdministrativeAuthority(GuildModel.Occupation occupation);
		public static bool HasGuildSettingAuthority(GuildModel.Occupation occupation);
		public static bool IsEnabledInvite(AtgenGuild guild = null);
		public static bool IsEnabledJoin(AtgenGuild guild);
		public static bool IsReceiveInvite();
		public static bool IsPenaltyTime();
		public static bool IsInGuildOrPenaltyTime();
	}
}
