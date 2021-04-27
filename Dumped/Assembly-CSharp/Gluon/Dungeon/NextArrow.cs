/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class NextArrow : FastUpdateMonoBehaviour
	{
		// Fields
		public int index;
		public int nextAreaIndex;
		public int targetIndex;
		[SerializeField]
		private bool isNotPlayTriggerEffect;
		[HideInInspector]
		[SerializeField]
		private bool isBossTypeOverride;
		[HideInInspector]
		[SerializeField]
		private bool overrideValue;
		[NonSerialized]
		public bool isNotPlayEffect;
		[NonSerialized]
		public bool isCautionBoss;
		private const string effectName = "EFF_DUN_ETC_001_001";
		private static bool hitFlag;
	
		// Nested types
		[Flags]
		public enum KickTriggerType
		{
			BLUE_8 = 8,
			RED_9 = 9,
			GREEN_10 = 10,
			YELLOW_11 = 11
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__14 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NextArrow __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__14(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CoPlayEffect_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public NextArrow __4__this;
			public Transform targetTrans;
			private KickTriggerType _kickTrigger_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoPlayEffect_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public NextArrow();
		static NextArrow();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		public void InitializeBossType();
		[IteratorStateMachine]
		private IEnumerator Start();
		public void PlayEffect(Transform t);
		[IteratorStateMachine]
		private IEnumerator CoPlayEffect(Transform targetTrans);
		private void OnTriggerStay(Collider other);
	}
}
