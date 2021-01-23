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
	public class ShootingResultScene : SceneBase
	{
		// Fields
		[SerializeField]
		private Camera mainCamera;
		public static string prefabDir;
		private ShootingResultUiCanvas mainCanvas;
		private static ShootingResultScene instance;
	
		// Properties
		public static ShootingResultScene Instance { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__9 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ShootingResultScene __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ShootingResultScene();
		static ShootingResultScene();
	
		// Methods
		private bool IsInstanceEmpty();
		private void Awake();
		private void Start();
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		private void OnDestroy();
		private new void OnApplicationPause(bool pauseStatus);
	}
}
