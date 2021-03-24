/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriAtomExAsrRack : CriDisposable
{
	// Fields
	public static int defaultRackId;
	private int _rackId;

	// Properties
	public int rackId { get; }
	public static Config defaultConfig { get; }

	// Nested types
	public struct Config
	{
		// Fields
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
		// Fields
		public byte reserved;
	}

	// Constructors
	public CriAtomExAsrRack(Config config, PlatformConfig platformConfig);
	static CriAtomExAsrRack();

	// Methods
	public override void Dispose();
	~CriAtomExAsrRack();
	private static extern int CRIWARE04B3A4F8(in Config config, in PlatformConfig platformConfig);
	private static extern void criAtomExAsrRack_Destroy(int rackId);
	private static extern void criAtomExAsrRack_AttachDspBusSetting(int rackId, string setting, IntPtr work, int workSize);
	private static extern void criAtomExAsrRack_DetachDspBusSetting(int rackId);
	private static extern void criAtomExAsrRack_ApplyDspBusSnapshot(int rackId, string snapshotName, int timeMs);
}

