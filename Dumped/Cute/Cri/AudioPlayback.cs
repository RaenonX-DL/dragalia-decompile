using System.Runtime.CompilerServices;
using CriWare;

namespace Cute.Cri
{
	public struct AudioPlayback
	{
		private CriAtomExPlayback criAtomExPlayback;

		public uint PlaybackId => default(uint);

		public CriAtomExPlayback.Status Status => default(CriAtomExPlayback.Status);

		public long Time => default(long);

		public bool IsError
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public SoundGroup SoundGroup
		{
			[CompilerGenerated]
			get
			{
				return default(SoundGroup);
			}
			[CompilerGenerated]
			private set
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
			private set
			{
			}
		}

		public int AtomSourceListIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string CueSheetName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string CueName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int CueId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool GetNumPlayedSamples(out long numSamples, out int samplingRate)
		{
			return default(bool);
		}

		public bool GetFormatInfo(out CriAtomEx.FormatInfo info)
		{
			return default(bool);
		}

		public bool IsLoop()
		{
			return default(bool);
		}

		public float GetLoopLengthTime()
		{
			return default(float);
		}

		public float GetIntroLengthTime()
		{
			return default(float);
		}

		public AudioPlayback(CriAtomExPlayback playback, bool isError, SoundGroup soundGroup, bool is3dSound, int atomSourceListIndex, string cueSheetName, string cueName, int cueId)
		{
		}

		public static AudioPlayback Error(SoundGroup soundGroup)
		{
			return default(AudioPlayback);
		}
	}
}
