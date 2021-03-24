/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class DirectionalDropItemBox : DropItemBox
	{
		// Fields
		private MeshRenderer fixedRenderer;
		public string normalEffectName;
		public int normalEffectTrigger;
		public string rareEffectName;
		public int rareEffectTrigger;
		private EffectObject effectObject;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Disppear_d__9 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DirectionalDropItemBox __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Disppear_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DirectionalDropItemBox();
	
		// Methods
		protected override void Start();
		public override void OnCollided(GameObject target, CollisionHitAttribute data);
		private new void OnCollided(GameObject target, bool fromEvent);
		[IteratorStateMachine]
		private new IEnumerator Disppear();
		public override void OnEvent(DungeonObject eventObject, GameObject target);
	}
}
