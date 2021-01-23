/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircle2DScene : SceneBase
	{
		// Fields
		public Camera uiCamera;
		public Camera flashCamera;
		public GrowthManaCircleModel manaCircleModel;
		public Canvas bgCanvas;
		public GameObject releaseEffectBase;
		public GrowthManaCircleSoundController soundController;
		[CompilerGenerated]
		private int _targetCharaId_k__BackingField;
		[HideInInspector]
		public GrowthManaCircle2DUICanvas mainCanvas;
		private GrowthManaCircleStatusCanvas statusCanvas;
		private BackButton backButton;
		private BaseCanvasContents baseCanvasContents;
	
		// Properties
		public int targetCharaId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public Action callback;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _SendReleasePieceData_b__0();
		}
	
		[CompilerGenerated]
		private struct _SendReleasePieceData_d__23 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public Action callback;
			public GrowthManaCircle2DScene __4__this;
			public int[] pieceIds;
			public bool isGrowRelease;
			private __c__DisplayClass23_0 __8__1;
			private TaskAwaiter<CharaBuildupManaResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _SendLimitBreakData_d__24 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthManaCircle2DScene __4__this;
			public Action callback;
			private TaskAwaiter<CharaLimitBreakResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public GrowthManaCircle2DScene();
	
		// Methods
		private void Awake();
		private void Start();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		private void OnEnterScene();
		private void OnDestroy();
		public void BackButtonPressed();
		public void OnGrowthButtonPressed();
		public void OnAwakeningButtonPressed();
		public async void SendReleasePieceData(int[] pieceIds, int circleIndex, bool isGrowRelease, Action callback = null);
		public async void SendLimitBreakData(Action callback = null);
		public void ReloadSceneUI();
		public void SetupReleasePieceEffect();
		public void CloseReleasePieceEffect();
		public void StartTutorial();
		public void ShowTutorialFinishWindow();
		[CompilerGenerated]
		private void _StartTutorial_b__28_0();
		[CompilerGenerated]
		private void _ShowTutorialFinishWindow_b__29_0();
		[CompilerGenerated]
		private void _ShowTutorialFinishWindow_b__29_1();
		[CompilerGenerated]
		private void _ShowTutorialFinishWindow_b__29_2();
	}
}
