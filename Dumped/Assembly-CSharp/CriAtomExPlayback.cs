/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public struct CriAtomExPlayback
{
	// Fields
	[CompilerGenerated]
	private uint _id_k__BackingField;
	public const uint invalidId = 4294967295;

	// Properties
	public uint id { [CompilerGenerated] get; [CompilerGenerated] private set; }
	public Status status { get; }
	public long time { get; }
	public long timeSyncedWithAudio { get; }

	// Nested types
	public enum Status
	{
		Prep = 1,
		Playing = 2,
		Removed = 3
	}

	public struct TrackInfo
	{
		// Fields
		public uint id;
		public CriAtomEx.CueType sequenceType;
		public IntPtr playerHn;
		public ushort trackNo;
		public ushort reserved;
	}

	// Constructors
	public CriAtomExPlayback(uint id);

	// Methods
	public void Stop(bool ignoresReleaseTime);
	public void Pause();
	public void Resume(CriAtomEx.ResumeMode mode);
	public bool IsPaused();
	public bool GetFormatInfo(out CriAtomEx.FormatInfo info);
	public Status GetStatus();
	public long GetTime();
	public long GetTimeSyncedWithAudio();
	public bool GetNumPlayedSamples(out long numSamples, out int samplingRate);
	public long GetSequencePosition();
	public int GetCurrentBlockIndex();
	public bool GetTrackInfo(out TrackInfo info);
	public bool GetBeatSyncInfo(out CriAtomExBeatSync.Info info);
	public void SetNextBlockIndex(int index);
	public void Stop();
	public void StopWithoutReleaseTime();
	public void Pause(bool sw);
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

