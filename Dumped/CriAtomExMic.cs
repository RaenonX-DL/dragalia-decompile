using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class CriAtomExMic : CriDisposable
{
	public struct DeviceInfo
	{
		public string deviceId;

		public string deviceName;

		public uint deviceFlags;

		public int maxChannels;

		public int maxSamplingRate;
	}

	public struct Config
	{
		public string deviceId;

		public uint flags;

		public int numChannels;

		public int samplingRate;

		public uint frameSize;

		public uint bufferingTime;

		public IntPtr context;

		public static Config Default => default(Config);
	}

	public class Effect
	{
		public IntPtr handle
		{
			[CompilerGenerated]
			get
			{
				return default(IntPtr);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public IntPtr afxInstance
		{
			[CompilerGenerated]
			get
			{
				return default(IntPtr);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Effect(IntPtr handle, IntPtr afxInstance)
		{
		}
	}

	private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomMic.";

	private const string errorAlreadyInitialized = "[CRIWARE] CriAtomMic module is already initialized.";

	private const string errorNotInitialized = "[CRIWARE] CriAtomMic module is not initialized.";

	private IntPtr handle;

	private IntPtr[] bufferPointers;

	private CriAudioWriteStream outputWriteStream;

	public static bool isInitialized
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

	public static void InitializeModule()
	{
	}

	public static void FinalizeModule()
	{
	}

	public static DeviceInfo[] GetDevices()
	{
		return null;
	}

	public static DeviceInfo? GetDefaultDevice()
	{
		return null;
	}

	public static bool IsFormatSupported(Config config)
	{
		return default(bool);
	}

	public static CriAtomExMic Create([Optional] Config? config)
	{
		return null;
	}

	private CriAtomExMic(IntPtr handle)
	{
	}

	public override void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	public void Start()
	{
	}

	public void Stop()
	{
	}

	public int GetNumChannels()
	{
		return default(int);
	}

	public int GetSamplingRate()
	{
		return default(int);
	}

	public uint GetNumBufferredSamples()
	{
		return default(uint);
	}

	public uint ReadData(float[] bufferMono)
	{
		return default(uint);
	}

	public uint ReadData(float[] bufferL, float[] bufferR)
	{
		return default(uint);
	}

	public void SetOutputWriteStream(CriAudioWriteStream stream)
	{
	}

	public CriAudioReadStream GetOutputReadStream()
	{
		return null;
	}

	public Effect AttachEffect(IntPtr afxInterface, float[] configParameters)
	{
		return null;
	}

	public void DetachEffect(Effect effect)
	{
	}

	public void SetEffectParameter(Effect effect, int parameterIndex, float parameterValue)
	{
	}

	public float GetEffectParameter(Effect effect, int parameterIndex)
	{
		return default(float);
	}

	public void SetEffectBypass(Effect effect, bool bypass)
	{
	}

	public void UpdateEffectParameters(Effect effect)
	{
	}

	private static extern void criAtomMicUnity_Initialize();

	private static extern void criAtomMicUnity_Finalize();

	private static extern int criAtomMic_GetNumDevices();

	private static extern bool criAtomMic_GetDevice(int index, out DeviceInfo info);

	private static extern bool criAtomMic_GetDefaultDevice(out DeviceInfo info);

	private static extern bool criAtomMic_IsFormatSupported([In] ref Config config);

	private static extern IntPtr criAtomMic_Create([In] ref Config config, IntPtr work, int work_size);

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
