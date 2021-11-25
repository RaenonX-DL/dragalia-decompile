using System;

public class CriAtomExPlayer : CriDisposable
{
	public enum Status
	{
		Stop,
		Prep,
		Playing,
		PlayEnd,
		Error
	}

	private struct Config
	{
		public CriAtomEx.VoiceAllocationMethod voiceAllocationMethod;

		public int maxPathStrings;

		public int maxPath;

		public int maxAisacs;

		public bool updatesTime;

		public bool enableAudioSyncedTimer;
	}

	public enum TimeStretchParameterId
	{
		Ratio,
		FrameTime,
		Quality
	}

	public enum PitchShifterParameterId
	{
		Pitch,
		Formant,
		Mode
	}

	private bool hasExistingNativeHandle;

	private IntPtr entryPoolHandle;

	private int _entryPoolCapacity;

	private int max_path;

	private IntPtr handle;

	public IntPtr nativeHandle => default(IntPtr);

	public bool isAvailable => default(bool);

	public int entryPoolCapacity => default(int);

	public CriAtomExPlayer()
	{
	}

	public CriAtomExPlayer(int maxPath, int maxPathStrings)
	{
	}

	public CriAtomExPlayer(bool enableAudioSyncedTimer)
	{
	}

	public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer)
	{
	}

	public CriAtomExPlayer(IntPtr existingNativeHandle)
	{
	}

	public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer, IntPtr existingNativeHandle)
	{
	}

	public override void Dispose()
	{
	}

	public void SetCue(CriAtomExAcb acb, string name)
	{
	}

	public void SetCue(CriAtomExAcb acb, int id)
	{
	}

	public void SetCueIndex(CriAtomExAcb acb, int index)
	{
	}

	public void SetContentId(CriFsBinder binder, int contentId)
	{
	}

	public void SetFile(CriFsBinder binder, string path)
	{
	}

	public void SetData(byte[] buffer, int size)
	{
	}

	public void SetData(IntPtr buffer, int size)
	{
	}

	public void SetFormat(CriAtomEx.Format format)
	{
	}

	public void SetNumChannels(int numChannels)
	{
	}

	public void SetSamplingRate(int samplingRate)
	{
	}

	public void PrepareEntryPool(int capacity, bool stopOnEmpty)
	{
	}

	public int GetNumEntries()
	{
		return default(int);
	}

	public bool EntryFile(CriFsBinder binder, string path, bool repeat)
	{
		return default(bool);
	}

	public bool EntryContentId(CriFsBinder binder, int contentId, bool repeat)
	{
		return default(bool);
	}

	public bool EntryData(byte[] buffer, int size, bool repeat)
	{
		return default(bool);
	}

	public bool EntryData(IntPtr buffer, int size, bool repeat)
	{
		return default(bool);
	}

	public bool EntryCue(CriAtomExAcb acb, string name, bool repeat)
	{
		return default(bool);
	}

	public CriAtomExPlayback Start()
	{
		return default(CriAtomExPlayback);
	}

	public CriAtomExPlayback Prepare()
	{
		return default(CriAtomExPlayback);
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

	public void SetVolume(float volume)
	{
	}

	public void SetPitch(float pitch)
	{
	}

	public void SetPan3dAngle(float angle)
	{
	}

	public void SetPan3dInteriorDistance(float distance)
	{
	}

	public void SetPan3dVolume(float volume)
	{
	}

	public void SetPanType(CriAtomEx.PanType panType)
	{
	}

	public void SetSendLevel(int channel, CriAtomEx.Speaker id, float level)
	{
	}

	public void SetBiquadFilterParameters(CriAtomEx.BiquadFilterType type, float frequency, float gain, float q)
	{
	}

	public void SetBandpassFilterParameters(float cofLow, float cofHigh)
	{
	}

	public void SetBusSendLevel(string busName, float level)
	{
	}

	[Obsolete]
	public void SetBusSendLevel(int busId, float level)
	{
	}

	public void SetBusSendLevelOffset(string busName, float levelOffset)
	{
	}

	[Obsolete]
	public void SetBusSendLevelOffset(int busId, float levelOffset)
	{
	}

	public void AttachAisac(string globalAisacName)
	{
	}

	public void DetachAisac(string globalAisacName)
	{
	}

	public void SetAisacControl(string controlName, float value)
	{
	}

	[Obsolete]
	public void SetAisac(string controlName, float value)
	{
	}

	public void SetAisacControl(uint controlId, float value)
	{
	}

	[Obsolete]
	public void SetAisac(uint controlId, float value)
	{
	}

	public bool GetAttachedAisacInfo(int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo)
	{
		return default(bool);
	}

	public void Set3dSource(CriAtomEx3dSource source)
	{
	}

	public void Set3dListener(CriAtomEx3dListener listener)
	{
	}

	public void SetStartTime(long startTimeMs)
	{
	}

	public void SetFirstBlockIndex(int index)
	{
	}

	public void SetSelectorLabel(string selector, string label)
	{
	}

	public void ClearSelectorLabels()
	{
	}

	public void SetCategory(int categoryId)
	{
	}

	public void SetCategory(string categoryName)
	{
	}

	public void UnsetCategory()
	{
	}

	public void SetCuePriority(int priority)
	{
	}

	public void SetVoicePriority(int priority)
	{
	}

	public void SetVoiceControlMethod(CriAtomEx.VoiceControlMethod method)
	{
	}

	public void SetPreDelayTime(float time)
	{
	}

	public void SetEnvelopeAttackTime(float time)
	{
	}

	public void SetEnvelopeHoldTime(float time)
	{
	}

	public void SetEnvelopeDecayTime(float time)
	{
	}

	public void SetEnvelopeReleaseTime(float time)
	{
	}

	public void SetEnvelopeSustainLevel(float level)
	{
	}

	public void AttachFader()
	{
	}

	public void DetachFader()
	{
	}

	public void SetFadeOutTime(int ms)
	{
	}

	public void SetFadeInTime(int ms)
	{
	}

	public void SetFadeInStartOffset(int ms)
	{
	}

	public void SetFadeOutEndDelay(int ms)
	{
	}

	public bool IsFading()
	{
		return default(bool);
	}

	public void ResetFaderParameters()
	{
	}

	public void SetGroupNumber(int group_no)
	{
	}

	public void Update(CriAtomExPlayback playback)
	{
	}

	public void UpdateAll()
	{
	}

	public void ResetParameters()
	{
	}

	public long GetTime()
	{
		return default(long);
	}

	public Status GetStatus()
	{
		return default(Status);
	}

	public float GetParameterFloat32(CriAtomEx.Parameter id)
	{
		return default(float);
	}

	public uint GetParameterUint32(CriAtomEx.Parameter id)
	{
		return default(uint);
	}

	public int GetParameterSint32(CriAtomEx.Parameter id)
	{
		return default(int);
	}

	public void SetSoundRendererType(CriAtomEx.SoundRendererType type)
	{
	}

	public void SetRandomSeed(uint seed)
	{
	}

	public void Loop(bool sw)
	{
	}

	public void SetAsrRackId(int asr_rack_id)
	{
	}

	public void SetVoicePoolIdentifier(uint identifier)
	{
	}

	public void SetDspTimeStretchRatio(float ratio)
	{
	}

	public void SetDspPitchShifterPitch(float pitch)
	{
	}

	public void SetDspParameter(int id, float value)
	{
	}

	public void SetSequencePrepareTime(uint ms)
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

	~CriAtomExPlayer()
	{
	}

	private static extern IntPtr criAtomExPlayer_Create(ref Config config, IntPtr work, int work_size);

	private static extern void criAtomExPlayer_Destroy(IntPtr player);

	private static extern void criAtomExPlayer_SetCueId(IntPtr player, IntPtr acb_hn, int id);

	private static extern void criAtomExPlayer_SetCueName(IntPtr player, IntPtr acb_hn, string cue_name);

	private static extern void criAtomExPlayer_SetCueIndex(IntPtr player, IntPtr acb_hn, int index);

	private static extern void criAtomExPlayer_SetFile(IntPtr player, IntPtr binder, string path);

	private static extern void criAtomExPlayer_SetData(IntPtr player, byte[] buffer, int size);

	private static extern void criAtomExPlayer_SetData(IntPtr player, IntPtr buffer, int size);

	private static extern void criAtomExPlayer_SetContentId(IntPtr player, IntPtr binder, int id);

	private static extern void criAtomExPlayer_SetVoicePoolIdentifier(IntPtr player, uint identifier);

	private static extern uint criAtomExPlayer_Start(IntPtr player);

	private static extern uint criAtomExPlayer_Prepare(IntPtr player);

	private static extern void criAtomExPlayer_Stop(IntPtr player);

	private static extern void criAtomExPlayer_StopWithoutReleaseTime(IntPtr player);

	private static extern void criAtomExPlayer_Pause(IntPtr player, bool sw);

	private static extern void criAtomExPlayer_Resume(IntPtr player, CriAtomEx.ResumeMode mode);

	private static extern bool criAtomExPlayer_IsPaused(IntPtr player);

	private static extern Status criAtomExPlayer_GetStatus(IntPtr player);

	private static extern long criAtomExPlayer_GetTime(IntPtr player);

	private static extern void criAtomExPlayer_SetFormat(IntPtr player, CriAtomEx.Format format);

	private static extern void criAtomExPlayer_SetNumChannels(IntPtr player, int num_channels);

	private static extern void criAtomExPlayer_SetSamplingRate(IntPtr player, int sampling_rate);

	private static extern IntPtr CRIWAREA85D9DF7(IntPtr player, int capacity, int max_path, bool stopOnEmpty);

	private static extern void CRIWARE412ABF9D(IntPtr pool);

	private static extern int CRIWARE567E547E(IntPtr pool);

	private static extern bool CRIWAREF1FC946E(IntPtr pool, IntPtr binder, string path, bool repeat, int max_path);

	private static extern bool CRIWAREB50A1D83(IntPtr pool, IntPtr binder, int id, bool repeat);

	private static extern bool CRIWAREA1C88AE8(IntPtr pool, byte[] buffer, int size, bool repeat);

	private static extern bool CRIWAREA1C88AE8(IntPtr pool, IntPtr buffer, int size, bool repeat);

	private static extern bool CRIWARE4334E792(IntPtr pool, IntPtr acbhn, string name, bool repeat);

	private static extern void CRIWARED8274724(IntPtr pool);

	private static extern void criAtomExPlayer_SetStartTime(IntPtr player, long start_time_ms);

	private static extern void criAtomExPlayer_SetSequencePrepareTime(IntPtr player, uint seq_prep_time_ms);

	private static extern void criAtomExPlayer_LimitLoopCount(IntPtr player, int count);

	private static extern void criAtomExPlayer_Update(IntPtr player, uint id);

	private static extern void criAtomExPlayer_UpdateAll(IntPtr player);

	private static extern void criAtomExPlayer_ResetParameters(IntPtr player);

	private static extern float criAtomExPlayer_GetParameterFloat32(IntPtr player, CriAtomEx.Parameter id);

	private static extern uint criAtomExPlayer_GetParameterUint32(IntPtr player, CriAtomEx.Parameter id);

	private static extern int criAtomExPlayer_GetParameterSint32(IntPtr player, CriAtomEx.Parameter id);

	private static extern IntPtr criAtomExPlayer_GetPlayerParameter(IntPtr player);

	private static extern void criAtomExPlayerParameter_RemoveParameter(IntPtr player_parameter, ushort id);

	private static extern void criAtomExPlayer_SetVolume(IntPtr player, float volume);

	private static extern void criAtomExPlayer_SetPitch(IntPtr player, float pitch);

	private static extern void criAtomExPlayer_SetPan3dAngle(IntPtr player, float pan3d_angle);

	private static extern void criAtomExPlayer_SetPan3dInteriorDistance(IntPtr player, float pan3d_interior_distance);

	private static extern void criAtomExPlayer_SetPan3dVolume(IntPtr player, float pan3d_volume);

	private static extern void criAtomExPlayer_SetPanType(IntPtr player, CriAtomEx.PanType panType);

	private static extern void criAtomExPlayer_SetSendLevel(IntPtr player, int channel, CriAtomEx.Speaker id, float level);

	private static extern void criAtomExPlayer_SetBusSendLevel(IntPtr player, int bus_id, float level);

	private static extern void criAtomExPlayer_SetBusSendLevelByName(IntPtr player, string bus_name, float level);

	private static extern void criAtomExPlayer_SetBusSendLevelOffset(IntPtr player, int bus_id, float level_offset);

	private static extern void criAtomExPlayer_SetBusSendLevelOffsetByName(IntPtr player, string bus_name, float level_offset);

	private static extern void criAtomExPlayer_SetBandpassFilterParameters(IntPtr player, float cof_low, float cof_high);

	private static extern void criAtomExPlayer_SetBiquadFilterParameters(IntPtr player, CriAtomEx.BiquadFilterType type, float frequency, float gain, float q);

	private static extern void criAtomExPlayer_SetVoicePriority(IntPtr player, int priority);

	private static extern void criAtomExPlayer_SetVoiceControlMethod(IntPtr player, CriAtomEx.VoiceControlMethod method);

	private static extern void criAtomExPlayer_SetAisacControlById(IntPtr player, ushort control_id, float control_value);

	private static extern void criAtomExPlayer_SetAisacControlByName(IntPtr player, string control_name, float control_value);

	private static extern void criAtomExPlayer_Set3dSourceHn(IntPtr player, IntPtr source);

	private static extern void criAtomExPlayer_Set3dListenerHn(IntPtr player, IntPtr listener);

	private static extern void criAtomExPlayer_SetCategoryById(IntPtr player, uint category_id);

	private static extern void criAtomExPlayer_SetCategoryByName(IntPtr player, string category_name);

	private static extern void criAtomExPlayer_UnsetCategory(IntPtr player);

	private static extern void criAtomExPlayer_SetCuePriority(IntPtr player, int cue_priority);

	private static extern void criAtomExPlayer_SetPreDelayTime(IntPtr player, float predelay_time_ms);

	private static extern void criAtomExPlayer_SetEnvelopeAttackTime(IntPtr player, float attack_time_ms);

	private static extern void criAtomExPlayer_SetEnvelopeHoldTime(IntPtr player, float hold_time_ms);

	private static extern void criAtomExPlayer_SetEnvelopeDecayTime(IntPtr player, float decay_time_ms);

	private static extern void criAtomExPlayer_SetEnvelopeReleaseTime(IntPtr player, float release_time_ms);

	private static extern void criAtomExPlayer_SetEnvelopeSustainLevel(IntPtr player, float susutain_level);

	private static extern void criAtomExPlayer_AttachFader(IntPtr player, IntPtr config, IntPtr work, int work_size);

	private static extern void criAtomExPlayer_AttachAisac(IntPtr player, string globalAisacName);

	private static extern void criAtomExPlayer_DetachAisac(IntPtr player, string globalAisacName);

	private static extern void criAtomExPlayer_DetachFader(IntPtr player);

	private static extern void criAtomExPlayer_SetFadeOutTime(IntPtr player, int ms);

	private static extern void criAtomExPlayer_SetFadeInTime(IntPtr player, int ms);

	private static extern void criAtomExPlayer_SetFadeInStartOffset(IntPtr player, int ms);

	private static extern void criAtomExPlayer_SetFadeOutEndDelay(IntPtr player, int ms);

	private static extern bool criAtomExPlayer_IsFading(IntPtr player);

	private static extern void criAtomExPlayer_ResetFaderParameters(IntPtr player);

	private static extern void criAtomExPlayer_SetGroupNumber(IntPtr player, int group_no);

	private static extern bool criAtomExPlayer_GetAttachedAisacInfo(IntPtr player, int aisac_attached_index, IntPtr aisac_info);

	private static extern void criAtomExPlayer_SetFirstBlockIndex(IntPtr player, int index);

	private static extern void criAtomExPlayer_SetSelectorLabel(IntPtr player, string selector, string label);

	private static extern void criAtomExPlayer_ClearSelectorLabels(IntPtr player);

	private static extern void criAtomExPlayer_SetSoundRendererType(IntPtr player, CriAtomEx.SoundRendererType type);

	private static extern void criAtomExPlayer_SetRandomSeed(IntPtr player, uint seed);

	private static extern void CRIWARE25219A74(IntPtr player, bool sw);

	private static extern void criAtomExPlayer_SetAsrRackId(IntPtr player, int asr_rack_id);

	private static extern void criAtomExPlayer_SetDspParameter(IntPtr player, int id, float value);
}
