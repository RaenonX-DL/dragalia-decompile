/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using SPFX;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class DungeonEffectObject : MonoBehaviour
	{
		// Fields
		public string effectName;
		public int effectTrigger;
		[NonSerialized]
		public EffectObject effectInstanceObject;
		public bool playEffectOnStart;
		[Tooltip]
		public GameObject linkedGameObject;
		[Range]
		[Tooltip]
		public float effectSpeed;
		[Tooltip]
		public Color effectColor;
		[Range]
		[Tooltip]
		public float effectOpacity;
		private bool readyPlayEffect;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _PlayEffectCoroutine_d__12 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DungeonEffectObject __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayEffectCoroutine_d__12(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DungeonEffectObject();
	
		// Methods
		private void Start();
		private void OnDestroy();
		public void PlayEffect();
		[IteratorStateMachine]
		private IEnumerator PlayEffectCoroutine();
		public SPFXInstance PlayEffectIfReady();
		public void StopEffect();
		private SPFXInstance PlayEffectInstance();
	}
}
