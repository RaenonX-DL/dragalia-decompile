/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class ShootingHomeScene : SceneBase
	{
		// Fields
		[SerializeField]
		private Camera mainCamera;
		[SerializeField]
		private Camera uiCamera;
		private ShootingHomeBGCanvas bgCanvas;
		private ShootingHomeUiCanvas uiCanvas;
		private HomeScoreBoardCanvas scoreBoard;
		public bool isScoreBoardActive;
		public static string prefabDir;
		public bool debugForceLoadEnding;
		private static ShootingHomeScene instance;
		public EpilogueState epilogueState;
	
		// Properties
		public static ShootingHomeScene Instance { get; }
	
		// Nested types
		public enum EpilogueState
		{
			none = 0,
			startFadeIn = 1,
			startBlackOut = 2,
			textFadeIn = 3,
			textWate = 4,
			textFadeOut = 5,
			end = 6,
			backKey = 7
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ShootingHomeScene __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ShootingHomeScene();
		static ShootingHomeScene();
	
		// Methods
		public static bool IsInstanceEmpty();
		private void Awake();
		private void Start();
		private new void OnApplicationPause(bool pauseStatus);
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		public void BGFadeIn(bool isNormal);
		public void FinishFadeIn();
		public void ActiveScoreBoard();
		public void HideScoreBoard();
		public void SetPostEffect(bool isActive);
		private void OnDestroy();
	}
}
