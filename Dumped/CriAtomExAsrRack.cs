using System;
using System.Runtime.InteropServices;

public class CriAtomExAsrRack : CriDisposable
{
	public struct Config
	{
		public float serverFrequency;

		public int numBuses;

		public int outputChannels;

		public int outputSamplingRate;

		public CriAtomEx.SoundRendererType soundRendererType;

		public int outputRackId;

		public IntPtr context;
	}

	public struct PlatformConfig
	{
		public byte reserved;
	}

	public static int defaultRackId;

	private int _rackId;

	public int rackId => default(int);

	public static Config defaultConfig => default(Config);

	public CriAtomExAsrRack(Config config, PlatformConfig platformConfig)
	{
	}

	public override void Dispose()
	{
	}

	~CriAtomExAsrRack()
	{
	}

	private static extern int CRIWARE04B3A4F8([In] ref Config config, [In] ref PlatformConfig platformConfig);

	private static extern void criAtomExAsrRack_Destroy(int rackId);

	private static extern void criAtomExAsrRack_AttachDspBusSetting(int rackId, string setting, IntPtr work, int workSize);

	private static extern void criAtomExAsrRack_DetachDspBusSetting(int rackId);

	private static extern void criAtomExAsrRack_ApplyDspBusSnapshot(int rackId, string snapshotName, int timeMs);
}
