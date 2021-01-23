/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BRItemDirectionParam : MonoBehaviour
	{
		// Fields
		public static BRItemDirectionParam instance;
		public static readonly float popDelayMin;
		public static readonly float popDelayMax;
		[SerializeField]
		[Tooltip]
		private AnimationCurve popJumpAnimCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve popScaleAnimCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve popRotScaleAnimCurve;
		[SerializeField]
		[Tooltip]
		private string popEffectLabel;
		[SerializeField]
		[Tooltip]
		private string popSoundLabel;
		[SerializeField]
		[Tooltip]
		public Vector3 idleOffset;
		[SerializeField]
		[Tooltip]
		public float idleAddRotY;
		[SerializeField]
		[Tooltip]
		private AnimationCurve cantCatchShakeAnimCurve;
		[SerializeField]
		[Tooltip]
		private string cantCatchEffectLabel;
		[SerializeField]
		[Tooltip]
		private string cantCatchSoundLabel;
		[SerializeField]
		[Tooltip]
		private AnimationCurve caughtJumpAnimCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve caughtScaleAnimCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve caughtStalkAnimCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve caughtRotScaleAnimCurve;
		[SerializeField]
		[Tooltip]
		private string caughtEffectLabel;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CoDirectionPop_d__22 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool ignoreSeFx;
			public BRItemDirectionParam __4__this;
			public Vector3 startPos;
			public Transform targetObj;
			public Vector3 endPos;
			private float _waitSec_5__2;
			private float _endSec_5__3;
			private BRItemBase _itemBase_5__4;
			private Vector3 _offsetNow_5__5;
			private Vector3 _scaleLog_5__6;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoDirectionPop_d__22(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CoDirectionCantCatch_d__24 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BRItemDirectionParam __4__this;
			public Transform targetObj;
			private float _waitSec_5__2;
			private float _endSec_5__3;
			private Vector3 _offsetNow_5__4;
			private Vector3 _localPosLog_5__5;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoDirectionCantCatch_d__24(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CoDirectionCaught_d__26 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Transform targetObj;
			public BRItemDirectionParam __4__this;
			public Transform stalkObj;
			private BRItemBase _itemBase_5__2;
			private float _waitSec_5__3;
			private float _endSec_5__4;
			private Vector3 _offsetNow_5__5;
			private Vector3 _scaleLog_5__6;
			private Vector3 _startPos_5__7;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoDirectionCaught_d__26(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BRItemDirectionParam();
		static BRItemDirectionParam();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		public float GetDirectionSecPop();
		public void SetDirectionPop(Transform targetObj, Vector3 startPos, Vector3 endPos, bool ignoreSeFx);
		[IteratorStateMachine]
		public IEnumerator CoDirectionPop(Transform targetObj, Vector3 startPos, Vector3 endPos, bool ignoreSeFx);
		public void SetDirectionCantCatch(Transform targetObj);
		[IteratorStateMachine]
		public IEnumerator CoDirectionCantCatch(Transform targetObj);
		public void SetDirectionCaught(Transform targetObj, Transform stalkObj);
		[IteratorStateMachine]
		public IEnumerator CoDirectionCaught(Transform targetObj, Transform stalkObj);
	}
}
