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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class FogParamTrigger : CommonObjectStatus
	{
		// Fields
		private BoxCollider hitCollider;
		private PlayerCtrl prevPlayerCtrl;
		protected static Coroutine progressCoroutine;
		protected static MonoBehaviour lastCoroutineStarter;
		[SerializeField]
		private FogData fogDataIn;
	
		// Nested types
		[Serializable]
		public class FogData
		{
			// Fields
			public float waitSec;
			public Color fogColor;
			public float startValue;
			public float endValue;
	
			// Constructors
			public FogData();
		}
	
		[CompilerGenerated]
		private sealed class _ChangeFogParam_d__10 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FogData fogDataNext;
			private EnvironmentMap _environmentMap_5__2;
			private FogData _fogDataNow_5__3;
			private float _waitSec_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ChangeFogParam_d__10(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public FogParamTrigger();
		static FogParamTrigger();
	
		// Methods
		protected override void Awake();
		public override void FastUpdate();
		private void OnTriggerEnter(Collider other);
		protected virtual void StartFadeIn();
		[IteratorStateMachine]
		private IEnumerator ChangeFogParam(FogData fogDataNext);
	}
}
