/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Dungeon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class EnemyDoor : SwitchDoor
	{
		// Fields
		[SerializeField]
		private Wall targetWall;
		[SerializeField]
		private string effectLabel;
		private static readonly int effectTriggerIdle;
		private static readonly int effectTriggerOpen;
		[SerializeField]
		private Transform effectAttachNode;
		private EffectObject effectObj;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CoExecDoor_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EnemyDoor __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoExecDoor_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public EnemyDoor();
		static EnemyDoor();
	
		// Methods
		protected override void Start();
		[IteratorStateMachine]
		protected IEnumerator CoExecDoor();
	}
}
