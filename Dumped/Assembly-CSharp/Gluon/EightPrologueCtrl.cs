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
	public class EightPrologueCtrl : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private string scriptName;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _ExecSequence_d__5 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EightPrologueCtrl __4__this;
			private MainGameCtrl _mainGameCtrl_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ExecSequence_d__5(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayScript_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string scriptName;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayScript_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public EightPrologueCtrl();
	
		// Methods
		public static bool IsEightPrologueQuest(int questId);
		public static GameObject LoadPrefab();
		private void Start();
		private void OnDestroy();
		[IteratorStateMachine]
		private IEnumerator ExecSequence();
		[IteratorStateMachine]
		private IEnumerator PlayScript(string scriptName);
	}
}
