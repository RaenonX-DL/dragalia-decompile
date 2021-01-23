/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleSoundController : MonoBehaviour
	{
		// Fields
		private AudioPlayback symbolEffectSoundPlayback;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _PlaySoundCoroutine_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public string soundName;
			public GrowthManaCircleSoundController __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlaySoundCoroutine_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GrowthManaCircleSoundController();
	
		// Methods
		public void PlayCircleMoveUpSound(float delay = 0f);
		public void PlayCircleRotateSound(float delay = 0f);
		public void PlayPointTouchedSound(float delay = 0f);
		public void PlayReleasePointFirstSound(float delay = 0f);
		public void PlayReleasePointSecondSound(float delay = 0f);
		public void PlayReleaseLimitFirstSound(float delay = 0f);
		public void PlayReleaseLimitSecondSound(float delay = 0f);
		public void PlayReleaseLimitVoice(int baseId, int variationId, float delay = 0f);
		public void PlayAllReleaseVoice(int baseId, int variationId, float delay = 0f);
		public void PlayAllReleasedSound(float delay = 0f);
		public void PlayReleaseSecondCircleSymbolSound();
		public void StopSymbolEffectSound();
		public void PlayReleaseSecondCircleEffectSound(float delay = 0f);
		public void PlayReleaseSecondCircleWhiteOutEffectSound(float delay = 0f);
		public void PlayReleaseSecondCircleConnectEffectSound(float delay = 0f);
		private void PlaySound(string soundName, float delay);
		[IteratorStateMachine]
		private IEnumerator PlaySoundCoroutine(string soundName, float delay);
		private void SendSoundErrorData(AudioPlayback soundPlayBack);
	}
}
