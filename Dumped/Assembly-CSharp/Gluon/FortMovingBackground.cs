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
	public class FortMovingBackground : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private bool isEnabled;
		[Header]
		[SerializeField]
		private string[] movingObjectName;
		private List<GameObject> movingObjectInstanceList;
		[Header]
		[SerializeField]
		private GameObject[] movingObjectRoot;
		[Header]
		[SerializeField]
		private MovingCurve[] movingCurve;
		[Header]
		[SerializeField]
		private float[] movingDuration;
		private float[] movingTimer;
		[Header]
		[Range]
		[SerializeField]
		private float[] movingStartRatio;
		private List<Vector3> initialPositionList;
		private const string prefabFolderPath = "Prefabs/OutGame/Fort/Layout/3D/";
	
		// Nested types
		[Serializable]
		public class MovingCurve
		{
			// Fields
			public AnimationCurve x;
			public AnimationCurve y;
			public AnimationCurve z;
	
			// Constructors
			public MovingCurve();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public int i;
			public FortMovingBackground __4__this;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _LoadMovingObjectAsync_b__0(GameObject prefabObj);
		}
	
		[CompilerGenerated]
		private sealed class _LoadMovingObjectAsync_d__12 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FortMovingBackground __4__this;
			private __c__DisplayClass12_0 __8__1;
			private int _curLoadedCount_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadMovingObjectAsync_d__12(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public FortMovingBackground();
	
		// Methods
		private void Start();
		[IteratorStateMachine]
		private IEnumerator LoadMovingObjectAsync();
		private void Update();
	}
}
