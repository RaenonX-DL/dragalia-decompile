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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class VolcanoManager : MonoBehaviour
	{
		// Fields
		public static VolcanoManager instance;
		private int eruptionStep;
		[SerializeField]
		private float[] eruptionIntervalSecArray;
		[SerializeField]
		private string effectLabelEruption;
		[SerializeField]
		private int effectTriggerIdEruption;
		private EffectObject effectObj;
		public string effectLabelBurnBush;
		public int effectTriggerBurnBush;
		public string effectLabelBreakHouse;
		public int effectTriggerBreakHouse;
		public static readonly int effectPoolCountBurn;
		[SerializeField]
		private string soundLabelEruption;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CoEruption_d__14 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public VolcanoManager __4__this;
			private float _waitSec_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoEruption_d__14(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public VolcanoManager();
		static VolcanoManager();
	
		// Methods
		private void Awake();
		private void Start();
		[IteratorStateMachine]
		private IEnumerator CoEruption();
	}
}
