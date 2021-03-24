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
	public class NoteTopScene : SceneBase
	{
		// Fields
		public GameObject serifPanel;
		public UnityEngine.UI.Text serifText;
		public GameObject bgPanel;
		public Canvas mainCanvas;
		public Image charaImage;
		private IEnumerator coroutine;
		private int serifIndex;
		private int serifNum;
		private string wording;
	
		// Nested types
		private enum NoteTopContents
		{
			Story = 0,
			Chara = 1,
			Monster = 2,
			Glossary = 3
		}
	
		[CompilerGenerated]
		private sealed class _Talk_d__15 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NoteTopScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Talk_d__15(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public NoteTopScene();
	
		// Methods
		private void Start();
		public void ClickStory();
		public void ClickChara();
		public void ClickMonster();
		public void ClickGlossary();
		[IteratorStateMachine]
		private IEnumerator Talk();
	}
}
