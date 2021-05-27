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
	public class DragonRelayCtrl : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private bool _isFollowerActive_k__BackingField;
	
		// Properties
		public bool isFollowerActive { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _NextWave_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int waveCnt;
			public DragonRelayCtrl __4__this;
			public int maxWaveIndex;
			private MainGameCtrl _mainGameCtrl_5__2;
			private InGameSettings.DragonRelayParam _param_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _NextWave_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DragonRelayCtrl();
	
		// Methods
		private void Start();
		private void Update();
		[IteratorStateMachine]
		public IEnumerator NextWave(int waveCnt, int maxWaveIndex);
		private float GetCameraFollowRateFunc();
		private void SetPosAndRot(CharacterSelector charaSelector, Vector3 pos, Quaternion rot);
		private void WarpToSafeArea(CharacterSelector activateSelector);
	}
}
