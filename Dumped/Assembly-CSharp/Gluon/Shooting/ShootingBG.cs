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

namespace Gluon.Shooting
{
	public class ShootingBG : MonoBehaviour
	{
		// Fields
		[NonSerialized]
		public Camera mainCamera;
		[Header]
		[SerializeField]
		public Transform bgNode;
		[SerializeField]
		public RuntimeAnimatorController cameraController;
		[Header]
		[SerializeField]
		public GameObject sleepingGO;
		public Animator sleepingDragon;
		private Animator animator;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _TriggerSleepCoroutine_d__8 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ShootingBG __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TriggerSleepCoroutine_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ShootingBG();
	
		// Methods
		private void Awake();
		public void Restart();
		[IteratorStateMachine]
		private IEnumerator TriggerSleepCoroutine();
		public void WakeDragon();
	}
}
