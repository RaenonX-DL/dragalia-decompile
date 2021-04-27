/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri.Audio
{
	public struct PlayParameters
	{
		// Fields
		public const float DefaultMinDistance = 10f;
		public const float DefaultMaxDistance = 100f;
		[CompilerGenerated]
		private CuteAudioPriority _Priority_k__BackingField;
		[CompilerGenerated]
		private bool _IsActionStartCue_k__BackingField;
		[CompilerGenerated]
		private bool _UseLowLatencyVoicePool_k__BackingField;
		private bool isValidVolume;
		private float volume;
		[CompilerGenerated]
		private bool _IsLoop_k__BackingField;
		[CompilerGenerated]
		private float _StartTime_k__BackingField;
		[CompilerGenerated]
		private float _FadeInTime_k__BackingField;
		[CompilerGenerated]
		private float _FadeOutTime_k__BackingField;
		[CompilerGenerated]
		private float _OffsetTime_k__BackingField;
		private bool isTimeStretch;
		private float timeStretchRatio;
		[CompilerGenerated]
		private bool _Is3dSound_k__BackingField;
		[CompilerGenerated]
		private Transform _EmitterTrans_k__BackingField;
		[CompilerGenerated]
		private Vector3 _EmitterPos_k__BackingField;
		[CompilerGenerated]
		private bool _IsHoming_k__BackingField;
		[CompilerGenerated]
		private float _InteriorDistance_k__BackingField;
		[CompilerGenerated]
		private float _MinDistance_k__BackingField;
		[CompilerGenerated]
		private float _MaxDistance_k__BackingField;
		[CompilerGenerated]
		private float _Pan3dAngle_k__BackingField;
	
		// Properties
		public CuteAudioPriority Priority { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsActionStartCue { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool UseLowLatencyVoicePool { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float Volume { get; set; }
		public bool IsLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float StartTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float FadeInTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float FadeOutTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float OffsetTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float TimeStretchRatio { get; set; }
		public bool Is3dSound { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Transform EmitterTrans { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 EmitterPos { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsHoming { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float InteriorDistance { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float MinDistance { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float MaxDistance { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float Pan3dAngle { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public PlayParameters(float volume = 1f, bool isLoop = false);
	}
}
