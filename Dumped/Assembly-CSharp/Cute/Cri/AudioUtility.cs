/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public static class AudioUtility
	{
		// Nested types
		public class VolumeFader : IUpdatable, IDisposable
		{
			// Fields
			[CompilerGenerated]
			private FadeStatus _Status_k__BackingField;
			[CompilerGenerated]
			private bool _Pause_k__BackingField;
			private float startVolume;
			private float endVolume;
			private float fadeTime;
			private Func<float> volumeGetter;
			private Action<float> volumeSetter;
			private Action startCallback;
			private Action endCallback;
			private bool isFadeOut;
			private float lastRealTime;
			private float elapsedTime;
			[CompilerGenerated]
			private float _ElapsedVolume_k__BackingField;
	
			// Properties
			public FadeStatus Status { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool Pause { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float ElapsedVolume { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Nested types
			public enum FadeStatus
			{
				None = 0,
				Started = 1,
				Doing = 2,
				Ended = 3,
				Completed = 4
			}
	
			// Constructors
			public VolumeFader();
	
			// Methods
			public void Dispose();
			public void Do(float startVolume, float endVolume, float fadeTime, Func<float> volumeGetter, Action<float> volumeSetter, Action startCallback = null, Action endCallback = null);
			public void FastUpdate();
			public void Complete();
			public void Kill();
		}
	
		[CompilerGenerated]
		private sealed class _DelayMethodCoroutine_d__1 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float waitTime;
			public Action process;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayMethodCoroutine_d__1(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public CuteAudioSource cuteAudioSource;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal bool _WaitForStopCoroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForStopCoroutine_d__3 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CuteAudioSource cuteAudioSource;
			public Action process;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForStopCoroutine_d__3(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Methods
		public static void DelayMethod(float waitTime, Action process);
		[IteratorStateMachine]
		private static IEnumerator DelayMethodCoroutine(float waitTime, Action process);
		public static void WaitForStop(CuteAudioSource cuteAudioSource, Action process);
		[IteratorStateMachine]
		private static IEnumerator WaitForStopCoroutine(CuteAudioSource cuteAudioSource, Action process);
	}
}
