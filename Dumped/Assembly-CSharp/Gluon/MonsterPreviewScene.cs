/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MonsterPreviewScene : SceneBase
	{
		// Fields
		public GameObject bgPanel;
		public Canvas mainCanvas;
		public GameObject monsterNode;
		public GameObject mainCamera;
		private int showMonsterId;
		[SerializeField]
		private MonsterLibraryCamera previewCameras;
		private Vector3 cameraPositionOffset;
		private Animator monsterAnimator;
		private bool playAnimationFlg;
		private int actionLoopIndex;
		private string[] animationStateNames;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _playAnimationDelay_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MonsterPreviewScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _playAnimationDelay_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MonsterPreviewScene();
	
		// Methods
		private void Start();
		private void BackButtonPressed();
		private void SetMonsterModel();
		private void SetCameraProperty();
		private bool SetupMonsterMasterData();
		public void ActionButtonPressed();
		[IteratorStateMachine]
		private IEnumerator playAnimationDelay();
	}
}
