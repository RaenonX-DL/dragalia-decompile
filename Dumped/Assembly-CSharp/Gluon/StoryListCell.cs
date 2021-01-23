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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryListCell : TableViewCell<Gluon.StoryListCellData>
	{
		// Fields
		public UnityEngine.UI.Text storyTitle;
		[SerializeField]
		public StoryButtonEvent buttonPressed;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _DelayAction_d__4 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public Action action;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayAction_d__4(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public StoryListCell();
	
		// Methods
		public override void UpdateContent(StoryListCellData data);
		public void OnButtonPressed();
		[IteratorStateMachine]
		private IEnumerator DelayAction(float delay, Action action);
		[CompilerGenerated]
		private void _OnButtonPressed_b__3_0();
	}
}
