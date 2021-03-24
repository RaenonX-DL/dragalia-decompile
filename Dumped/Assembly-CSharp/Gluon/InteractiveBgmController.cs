/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Cute.Cri.Audio;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InteractiveBgmController : MonoBehaviour
	{
		// Fields
		private Action _transitionStartCallback;
		private Action _beatActionCallback;
		private bool _reservedTransitionStart;
		private long comparisonNextPastEventTime;
	
		// Nested types
		public struct TransitionInfo
		{
			// Fields
			[CompilerGenerated]
			private long _LastPastMarkerTime_k__BackingField;
			[CompilerGenerated]
			private long _NextPastMarkerTime_k__BackingField;
			[CompilerGenerated]
			private long _TimeToNextPastMarker_k__BackingField;
			[CompilerGenerated]
			private long _TimeToTransition_k__BackingField;
			[CompilerGenerated]
			private int _NextPastMarkerType_k__BackingField;
			[CompilerGenerated]
			private bool _IsTransitionMarkerEnd_k__BackingField;
			[CompilerGenerated]
			private bool _IsError_k__BackingField;
	
			// Properties
			public long LastPastMarkerTime { [CompilerGenerated] get; [CompilerGenerated] set; }
			public long NextPastMarkerTime { [CompilerGenerated] get; [CompilerGenerated] set; }
			public long TimeToNextPastMarker { [CompilerGenerated] get; [CompilerGenerated] set; }
			public long TimeToTransition { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int NextPastMarkerType { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool IsTransitionMarkerEnd { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool IsError { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Methods
			public static TransitionInfo Error();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public Action beatActionCallback;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal bool _SetBeatActionCallback_b__0(Delegate item);
		}
	
		// Constructors
		public InteractiveBgmController();
	
		// Methods
		private InteractiveBGMElement GetInteractiveBgmSetting(string cueName);
		private void Update();
		public void SetTransitionStartCallback(Action transitionStartCallback);
		public void RemoveTransitionStartCallback(Action transitionStartCallback);
		public void ClearAllTransitionCallbacks();
		public void SetBeatActionCallback(Action beatActionCallback);
		public void RemoveBeatActionCallback(Action beatActionCallback);
		public void ClearAllBeatActionCallbacks();
		public static AudioPlayback Play(RequestCueInfo info, PlayParameters param);
		public TransitionInfo IndicateTransition(AudioPlayback playback);
		private static void TransitionSequencePosition(AudioPlayback playback, int transitionBlockId, float fadeTime);
		public TransitionInfo GetTransitionInfo();
		private TransitionInfo GetTransitionInfo(InteractiveBGMElement interactiveBGMSetting, AudioPlayback playback);
	}
}
