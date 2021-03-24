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
	public class BotMultiTutorialCtrl : MonoBehaviour
	{
		// Fields
		private float[] prevHpRates;
		private int deadEnemiesCount;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _PlayQuestStartStampCoroutine_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BotMultiTutorialCtrl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayQuestStartStampCoroutine_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ReplyStampCoroutine_d__8 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BotMultiTutorialCtrl __4__this;
			public int charaIndex;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ReplyStampCoroutine_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BotMultiTutorialCtrl();
	
		// Methods
		private void Start();
		private void OnEnemyDead(CharacterBase murderer);
		private void Update();
		public void PlayQuestStartStamp();
		[IteratorStateMachine]
		private IEnumerator PlayQuestStartStampCoroutine();
		public void ReplyStamp(int stampId);
		[IteratorStateMachine]
		private IEnumerator ReplyStampCoroutine(int charaIndex, int stampId);
		private void PlayStamp(int charaIndex, int stampId);
	}
}
