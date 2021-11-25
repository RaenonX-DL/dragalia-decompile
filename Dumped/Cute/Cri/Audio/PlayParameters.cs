using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cute.Cri.Audio
{
	public struct PlayParameters
	{
		public const float DefaultMinDistance = 10f;

		public const float DefaultMaxDistance = 100f;

		private bool isValidVolume;

		private float volume;

		private bool isTimeStretch;

		private float timeStretchRatio;

		public CuteAudioPriority Priority
		{
			[CompilerGenerated]
			get
			{
				return default(CuteAudioPriority);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsActionStartCue
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool UseLowLatencyVoicePool
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float Volume
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool IsLoop
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float StartTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float FadeInTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float FadeOutTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float OffsetTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float TimeStretchRatio
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool Is3dSound
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Transform EmitterTrans
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 EmitterPos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsHoming
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float InteriorDistance
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float MinDistance
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float MaxDistance
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float Pan3dAngle
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public PlayParameters(float volume = 1f, bool isLoop = false)
		{
		}
	}
}
