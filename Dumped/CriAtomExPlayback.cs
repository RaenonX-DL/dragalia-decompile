using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(0, Size = 4)]
public struct CriAtomExPlayback
{
	public enum Status
	{
		Prep = 1,
		Playing,
		Removed
	}

	public struct TrackInfo
	{
		public uint id;

		public CriAtomEx.CueType sequenceType;

		public IntPtr playerHn;

		public ushort trackNo;

		public ushort reserved;
	}

	public const uint invalidId = uint.MaxValue;

	public uint id
	{
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Status status => default(Status);

	public long time => default(long);

	public long timeSyncedWithAudio => default(long);

	public CriAtomExPlayback(uint id)
	{
	}

	public void Stop(bool ignoresReleaseTime)
	{
	}

	public void Pause()
	{
	}

	public void Resume(CriAtomEx.ResumeMode mode)
	{
	}

	public bool IsPaused()
	{
		return default(bool);
	}

	public bool GetFormatInfo(out CriAtomEx.FormatInfo info)
	{
		return default(bool);
	}

	public Status GetStatus()
	{
		return default(Status);
	}

	public long GetTime()
	{
		return default(long);
	}

	public long GetTimeSyncedWithAudio()
	{
		return default(long);
	}

	public bool GetNumPlayedSamples(out long numSamples, out int samplingRate)
	{
		return default(bool);
	}

	public long GetSequencePosition()
	{
		return default(long);
	}

	public int GetCurrentBlockIndex()
	{
		return default(int);
	}

	public bool GetTrackInfo(out TrackInfo info)
	{
		return default(bool);
	}

	public bool GetBeatSyncInfo(out CriAtomExBeatSync.Info info)
	{
		return default(bool);
	}

	public void SetNextBlockIndex(int index)
	{
	}

	public void Stop()
	{
	}

	public void StopWithoutReleaseTime()
	{
	}

	public void Pause(bool sw)
	{
	}

	private static extern void criAtomExPlayback_Stop(uint id);

	private static extern void criAtomExPlayback_StopWithoutReleaseTime(uint id);

	private static extern void criAtomExPlayback_Pause(uint id, bool sw);

	private static extern void criAtomExPlayback_Resume(uint id, CriAtomEx.ResumeMode mode);

	private static extern bool criAtomExPlayback_IsPaused(uint id);

	private static extern Status criAtomExPlayback_GetStatus(uint id);

	private static extern bool criAtomExPlayback_GetFormatInfo(uint id, out CriAtomEx.FormatInfo info);

	private static extern long criAtomExPlayback_GetTime(uint id);

	private static extern long criAtomExPlayback_GetTimeSyncedWithAudio(uint id);

	private static extern bool criAtomExPlayback_GetNumPlayedSamples(uint id, out long num_samples, out int sampling_rate);

	private static extern long criAtomExPlayback_GetSequencePosition(uint id);

	private static extern void criAtomExPlayback_SetNextBlockIndex(uint id, int index);

	private static extern int criAtomExPlayback_GetCurrentBlockIndex(uint id);

	private static extern bool criAtomExPlayback_GetPlaybackTrackInfo(uint id, out TrackInfo info);

	private static extern bool criAtomExPlayback_GetBeatSyncInfo(uint id, out CriAtomExBeatSync.Info info);
}
