/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingRoomScene : SceneBase
	{
		// Fields
		public Camera mainCamera;
		[HideInInspector]
		public MatchingRoomCanvas matchingRoomCanvas;
		private readonly string mainCanvasPath;
		public static MatchingReturToType returnFlag;
		public static GuestEnterRoomFromType enterRoomFromType;
		private static MatchingReturToType _savedReturnFlag;
		private AudioPlayback bgmPlayback;
		private string bgSceneName;
		private GameObject mainCanvasObj;
		private PartyScene partyScene;
		private int questId;
		private Canvas canvas;
		private List<MatchingRoomCharacterModelLoadTask> loadTaskList;
		private const string defaultBgm = "BGM_OUT_0003_01";
		private readonly string stampVoice;
		private bool _isGotoPartyScene;
		private bool beforeIsShowWeaponSkin;
	
		// Properties
		public static MatchingReturToType savedReturnFlag { get; private set; }
		public bool isGoToPartyScene { get; set; }
	
		// Nested types
		public enum MatchingReturToType
		{
			None = 0,
			HostQuestSelect = 1,
			GuestJoinCoop = 2,
			GuestQuestSelect = 3,
			GuestGuild = 4
		}
	
		public enum GuestEnterRoomFromType
		{
			None = 0,
			EventTab = 1,
			NormalTab = 2,
			IDInput = 3,
			Location = 4
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__27_0;
			public static Func<bool> __9__30_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__27_0();
			internal bool _SetupRenderBg_b__30_0();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__27 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MatchingRoomScene __4__this;
			private TouchGuardObject _touchGuard_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__27(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public float loadBeginTime;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal bool _SetupRenderBg_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _SetupRenderBg_d__30 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MatchingRoomScene __4__this;
			private TouchGuardObject _touchGuard_5__2;
			private SceneController _sceneController_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupRenderBg_d__30(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0
		{
			// Fields
			public CommonPopup popup;
			public bool isExitFromMatchingRoomButton;
			public Action onOK;
			public Action onCancel;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _OnTryExitFromMatchingScene_b__0();
			internal void _OnTryExitFromMatchingScene_b__1();
		}
	
		// Constructors
		public MatchingRoomScene();
		static MatchingRoomScene();
	
		// Methods
		private void Awake();
		private bool IsValidPlayFlow();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void Update();
		public static void RemoveReturnFlagForQuest();
		[IteratorStateMachine]
		private IEnumerator SetupRenderBg();
		public void OnInsertCharacter(int index, MatchingService.Room myRoom, int playerIndex, int memberIndex, bool isPlayVoice, int delayIndex = 0);
		public void OnRemoveCharacter(int index, MatchingService.Room myRoom, int delayIndex = 0);
		public void OnReplaceCharacter(int index, MatchingService.Room myRoom, int playerIndex, int memberIndex, bool isPlayVoice, int delayIndex = 0);
		public void OnReplacePlayerAndCharacter(int index, MatchingService.Room myRoom, int playerIndex, int memberIndex, bool isPlayVoice, int delayIndex = 0);
		public void UpdateCharacterInfoOnly(int index, MatchingService.Room myRoom, int playerIndex, int memberIndex);
		public void LandCharacter(int positionIndex, MatchingRoomPlayerData playerData, int memberIndex, bool isPlayCharaVoice, Action<GameObject> onLoaded);
		public void TakeOffCharacter(int positionIndex);
		public override void OnBeforeLeaving();
		public static void OnTryExitFromMatchingScene(Action onOK, Action onCancel = null, bool isExitFromMatchingRoomButton = false);
		private void OnChangeWeaponSkinSetting();
		public static void MatchingServiceDestroy();
		public static void OnGuestExitToList();
		public void SetupTutorial();
	}
}
