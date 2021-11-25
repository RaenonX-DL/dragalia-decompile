using System;
using System.Runtime.InteropServices;

public class CriAtomExAuxIn : CriDisposable
{
	public struct Config
	{
		public int maxChannels;

		public int maxSamplingRate;

		public CriAtomEx.SoundRendererType soundRendererType;

		public static Config Default => default(Config);
	}

	private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomExAuxIn.";

	private IntPtr handle;

	private CriAudioReadStream inputReadStream;

	public CriAtomExAuxIn([Optional] Config? config)
	{
	}

	public override void Dispose()
	{
	}

	public void Start()
	{
	}

	public void Stop()
	{
	}

	public void SetFormat(int numChannels, int samplingRate)
	{
	}

	public void GetFormat(out int numChannels, out int samplingRate)
	{
	}

	public void SetVolume(float volume)
	{
	}

	public void SetFrequencyRatio(float frequencyRatio)
	{
	}

	public void SetBusSendLevel(string busName, float level)
	{
	}

	public void SetInputReadStream(CriAudioReadStream stream)
	{
	}

	private static extern IntPtr criAtomAuxIn_Create([In] ref Config config, IntPtr work, int work_size);

	private static extern void criAtomAuxIn_Destroy(IntPtr aux_in);

	private static extern void criAtomAuxIn_Start(IntPtr aux_in);

	private static extern void criAtomAuxIn_Stop(IntPtr aux_in);

	private static extern void criAtomAuxIn_SetVolume(IntPtr aux_in, float volume);

	private static extern void criAtomAuxIn_SetFrequencyRatio(IntPtr aux_in, float ratio);

	private static extern void criAtomAuxIn_SetBusSendLevelByName(IntPtr aux_in, string bus_name, float level);

	private static extern void criAtomAuxIn_SetFormat(IntPtr aux_in, int num_channels, int sampling_rate);

	private static extern void criAtomAuxIn_GetFormat(IntPtr aux_in, out int num_channels, out int sampling_rate);

	private static extern void criAtomAuxIn_SetInputReadStream(IntPtr aux_in, IntPtr stream_cbfunc, IntPtr stream_ptr);
}
