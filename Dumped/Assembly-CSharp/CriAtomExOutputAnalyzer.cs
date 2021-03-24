/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriAtomExOutputAnalyzer : CriDisposable
{
	// Fields
	public const int MaximumSpectrumBands = 512;
	protected IntPtr handle;
	protected CriAtomExPlayer player;
	protected string busName;
	protected int numBands;
	protected int numCapturedPcmSamples;
	protected PcmCaptureCallback userPcmCaptureCallback;
	protected float[] dataL;
	protected float[] dataR;
	protected const int pcmCapturerNumMaxData = 512;
	protected static IntPtr InternalCallbackFunctionPointer;
	protected static InternalPcmCaptureCallback DelegateObject;
	protected static float[] DataL;
	protected static float[] DataR;
	protected static PcmCaptureCallback UserPcmCaptureCallback;

	// Properties
	public IntPtr nativeHandle { get; }

	// Nested types
	public delegate void PcmCaptureCallback(float[] dataL, float[] dataR, int numChannels, int numData);

	public struct Config
	{
		// Fields
		public bool enableLevelmeter;
		public bool enableSpectrumAnalyzer;
		public bool enablePcmCapture;
		public bool enablePcmCaptureCallback;
		public int numSpectrumAnalyzerBands;
		public int numCapturedPcmSamples;
	}

	[UnmanagedFunctionPointer]
	protected delegate void InternalPcmCaptureCallback(IntPtr dataL, IntPtr dataR, int numChannels, int numData);

	// Constructors
	public CriAtomExOutputAnalyzer(Config config);
	protected CriAtomExOutputAnalyzer();
	static CriAtomExOutputAnalyzer();

	// Methods
	public override void Dispose();
	protected void Dispose(bool disposing);
	public bool AttachExPlayer(CriAtomExPlayer player);
	public void DetachExPlayer();
	public bool AttachDspBus(string busName);
	public void DetachDspBus();
	public float GetRms(int channel);
	public void GetSpectrumLevels(ref float[] levels);
	public void GetPcmData(ref float[] data, int ch);
	public void SetPcmCaptureCallback(PcmCaptureCallback callback);
	public void ExecutePcmCaptureCallback();
	[Obsolete]
	public void ExecutePcmCaptureCallback(PcmCaptureCallback callback);
	~CriAtomExOutputAnalyzer();
	protected void InitializeWithConfig(Config config);
	[MonoPInvokeCallback]
	private static void Callback(IntPtr ptrL, IntPtr ptrR, int numChannels, int numData);
	protected static extern IntPtr criAtomExOutputAnalyzer_Create(in Config config);
	protected static extern void criAtomExOutputAnalyzer_Destroy(IntPtr analyzer);
	protected static extern void criAtomExOutputAnalyzer_AttachExPlayer(IntPtr analyzer, IntPtr player);
	protected static extern void criAtomExOutputAnalyzer_DetachExPlayer(IntPtr analyzer, IntPtr player);
	protected static extern void criAtomExOutputAnalyzer_AttachDspBusByName(IntPtr analyzer, string busName);
	protected static extern void criAtomExOutputAnalyzer_DetachDspBusByName(IntPtr analyzer, string busName);
	protected static extern float criAtomExOutputAnalyzer_GetRms(IntPtr analyzer, int channel);
	protected static extern IntPtr criAtomExOutputAnalyzer_GetSpectrumLevels(IntPtr analyzer);
	protected static extern IntPtr criAtomExOutputAnalyzer_GetPcmData(IntPtr analyzer, int ch);
	protected static extern void criAtomExOutputAnalyzer_ExecuteQueuedPcmCapturerCallbacks(IntPtr analyzer, IntPtr callback);
}

