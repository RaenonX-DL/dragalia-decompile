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
	public class AlbumPictureBookScene : SceneBase
	{
		// Fields
		[SerializeField]
		private Camera mainCamera;
		private Canvas albumCanvas;
		private AlbumPictureBookCanvas albumPictureBookCanvas;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__4_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _WaitPrevSceneExit_b__4_0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__4 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AlbumPictureBookScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__4(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public AlbumPictureBookScene();
	
		// Methods
		private void Start();
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		private void BackButtonPressed();
		public override void OnPresentReceived();
		public override void OnItemUsed();
	}
}
