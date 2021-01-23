/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FriendScene : SceneBase
	{
		// Fields
		[Header]
		[SerializeField]
		private Transform currentPanelNode;
		[SerializeField]
		private Transform nextPanelNode;
		[HideInInspector]
		public Canvas canvas;
		private bool bPrevPanelExitDone;
		private bool bNextHttpReady;
		private FriendPanelBase activePanel;
		private Coroutine waitReadyStateCoroutine;
		private BackButton backButton;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitForReadyState_d__19 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FriendScene __4__this;
			public FriendModel.PanelType type;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForReadyState_d__19(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public FriendScene();
	
		// Methods
		private void Awake();
		private void Start();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		private void LoadBG();
		public void SetCaption();
		public void SetBackButton();
		private void OnBackButtonPressed();
		private void OnEnterScene();
		public override void StartExitAnimation();
		public void SwitchToPanel(FriendModel.PanelType type);
		[IteratorStateMachine]
		private IEnumerator WaitForReadyState(FriendModel.PanelType type);
		private void ReleasePanel(FriendModel.PanelType type);
		private void RequestHttpForPanel(FriendModel.PanelType type);
		public void LoadPanel(FriendModel.PanelType type);
		public void SetNextHttpReady();
		private void OnDestroy();
		public void ClearChangeSceneCallbacks();
		public override void OnPresentReceived();
		[CompilerGenerated]
		private void _OnBackButtonPressed_b__15_0();
		[CompilerGenerated]
		private bool _WaitForReadyState_b__19_0();
		[CompilerGenerated]
		private void _ReleasePanel_b__20_0();
	}
}
