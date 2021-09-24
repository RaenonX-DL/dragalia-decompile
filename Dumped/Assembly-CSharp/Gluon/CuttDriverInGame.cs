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
	public class CuttDriverInGame : CuttDriver
	{
		// Fields
		protected float cuttTime;
		private bool resetPauseFlag;
		private bool skipAllFlag;
		private bool skipOnceFlag;
		protected string cuttDataName;
		protected GameObject cuttData;
		protected bool _isInitialized;
		protected bool _isIngameCutt;
		private bool stopUpdateFlag;
	
		// Properties
		public bool isInitialized { get; protected set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__15 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CuttDriverInGame __4__this;
			private Color _fadeColor_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__15(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CuttDriverInGame();
	
		// Methods
		public void SetIngameCutt();
		public void StopUpdate(bool flag);
		protected override void Awake();
		[IteratorStateMachine]
		public override IEnumerator Start();
		protected override void OnDestroy();
		public override void Update();
		protected void UpdateInGame();
		public void ResetPause();
		public void SkipAll();
		public bool IsLast();
		public bool IsPausing();
		private float GetPauseTime();
		public float GetWaitEventTime();
		public bool GetTapWait();
		public void ResetWaitEvent();
		public float GetNextCuttEventTime();
		public void SetLoadDataName(string name);
		public void ResetPlayTime(bool start, int jumpId = 0);
	}
}
