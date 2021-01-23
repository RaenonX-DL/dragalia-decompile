/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriAtomExMic : CriDisposable
{
	// Fields
	private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomMic.";
	private const string errorAlreadyInitialized = "[CRIWARE] CriAtomMic module is already initialized.";
	private const string errorNotInitialized = "[CRIWARE] CriAtomMic module is not initialized.";
	[CompilerGenerated]
	private static bool _isInitialized_k__BackingField;
	private IntPtr handle;
	private IntPtr[] bufferPointers;
	private CriAudioWriteStream outputWriteStream;

	// Properties
	public static bool isInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; }

	// Nested types
	public struct DeviceInfo
	{
		// Fields
		public string deviceId;
		public string deviceName;
		public uint deviceFlags;
		public int maxChannels;
		public int maxSamplingRate;
	}

	public struct Config
	{
		// Fields
		public string deviceId;
		public uint flags;
		public int numChannels;
		public int samplingRate;
		public uint frameSize;
		public uint bufferingTime;
		public IntPtr context;

		// Properties
		public static Config Default { get; }
	}

	public class Effect
	{
		// Fields
		[CompilerGenerated]
		private IntPtr _handle_k__BackingField;
		[CompilerGenerated]
		private IntPtr _afxInstance_k__BackingField;

		// Properties
		public IntPtr handle { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public IntPtr afxInstance { [CompilerGenerated] get; [CompilerGenerated] private set; }

		// Constructors
		public Effect(IntPtr handle, IntPtr afxInstance);
	}

	// Constructors
	private CriAtomExMic(IntPtr handle);

	// Methods
	public static void InitializeModule();
	public static void FinalizeModule();
	public static DeviceInfo[] GetDevices();
	public static DeviceInfo? GetDefaultDevice();
	public static bool IsFormatSupported(Config config);
	public static CriAtomExMic Create(Config? config = default);
	public override void Dispose();
	private void Dispose(bool disposing);
	public void Start();
	public void Stop();
	public int GetNumChannels();
	public int GetSamplingRate();
	public uint GetNumBufferredSamples();
	public uint ReadData(float[] bufferMono);
	public uint ReadData(float[] bufferL, float[] bufferR);
	public void SetOutputWriteStream(CriAudioWriteStream stream);
	public CriAudioReadStream GetOutputReadStream();
	public Effect AttachEffect(IntPtr afxInterface, float[] configParameters);
	public void DetachEffect(Effect effect);
	public void SetEffectParameter(Effect effect, int parameterIndex, float parameterValue);
	public float GetEffectParameter(Effect effect, int parameterIndex);
	public void SetEffectBypass(Effect effect, bool bypass);
	public void UpdateEffectParameters(Effect effect);
	private static extern void criAtomMicUnity_Initialize();
	private static extern void criAtomMicUnity_Finalize();
	private static extern int criAtomMic_GetNumDevices();
	private static extern bool criAtomMic_GetDevice(int index, out DeviceInfo info);
	private static extern bool criAtomMic_GetDefaultDevice(out DeviceInfo info);
	private static extern bool criAtomMic_IsFormatSupported(in Config config);
	private static extern IntPtr criAtomMic_Create(in Config config, IntPtr work, int work_size);
	private static extern void criAtomMic_Destroy(IntPtr mic);
	private static extern void criAtomMic_Start(IntPtr mic);
	private static extern void criAtomMic_Stop(IntPtr mic);
	private static extern int criAtomMic_GetNumChannels(IntPtr mic);
	private static extern int criAtomMic_GetSamplingRate(IntPtr mic);
	private static extern uint criAtomMic_GetNumBufferredSamples(IntPtr mic);
	private static extern uint criAtomMic_ReadData(IntPtr mic, IntPtr[] data, uint num_samples);
	private static extern void criAtomMic_SetOutputWriteStream(IntPtr mic, IntPtr stream_cbfunc, IntPtr stream_ptr);
	private static extern IntPtr criAtomMic_GetOutputReadStream();
	private static extern int criAtomMic_CalculateWorkSizeForEffect(IntPtr mic, IntPtr afx_interface, float[] config_parameters, uint num_config_parameters);
	private static extern IntPtr criAtomMic_AttachEffect(IntPtr mic, IntPtr afx_interface, float[] config_parameters, uint num_config_parameters, IntPtr work, int work_size);
	private static extern void criAtomMic_DetachEffect(IntPtr mic, IntPtr effect);
	private static extern IntPtr criAtomMic_GetEffectInstance(IntPtr mic, IntPtr effect);
	private static extern void criAtomMic_SetEffectBypass(IntPtr mic, IntPtr effect, bool bypass);
	private static extern void criAtomMic_SetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index, float parameter_value);
	private static extern float criAtomMic_GetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index);
	private static extern void criAtomMic_UpdateEffectParameters(IntPtr mic, IntPtr effect);
}

