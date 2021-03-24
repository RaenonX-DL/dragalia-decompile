/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ProfileScene : SceneBase
	{
		// Fields
		public Canvas mainCanvas;
		public GameObject bgPanel;
		public Image charaImage;
		public GameObject downloadGreenLight;
		private Canvas popupBaseCanvas;
		private string playerIDStr;
		private string playerNameStr;
		private PlayerProfile profile;
		private EditNameDialog editDialog;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__9_0;
			public static Func<bool> __9__9_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__9_0();
			internal bool _Start_b__9_1();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__9 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ProfileScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _CopyIDButtonPressed_b__0();
			internal void _CopyIDButtonPressed_b__1();
			internal void _CopyIDButtonPressed_b__2();
		}
	
		// Constructors
		public ProfileScene();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		private void OnEnterScene();
		public void JumpAnotherName();
		public void EditNameButtonPressed();
		public void CopyIDButtonPressed();
		private void ShowEditNameWindow();
		[CompilerGenerated]
		private void _ShowEditNameWindow_b__16_0(string newName);
	}
}
