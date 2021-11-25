using System;
using UnityEngine.Rendering;

public class CriManaPlugin
{
	private static int initializationCount;

	private static bool isConfigured;

	private static bool enabledMultithreadedRendering;

	public static int renderingEventOffset;

	public static bool isInitialized => default(bool);

	public static bool isMultithreadedRenderingEnabled => default(bool);

	public static void SetConfigParameters(bool graphicsMultiThreaded, int num_decoders, int max_num_of_entries)
	{
	}

	private static void SetupVp9()
	{
	}

	[Obsolete]
	public static void SetConfigAdditonalParameters_VITA(bool use_h264_playback, int width, int height)
	{
	}

	public static void SetConfigAdditonalParameters_PC(bool use_h264_playback)
	{
	}

	public static void SetConfigAdditonalParameters_ANDROID(bool use_h264_playback)
	{
	}

	public static void SetConfigAdditonalParameters_WEBGL(string webworkerPath, uint heapSize)
	{
	}

	public static void InitializeLibrary()
	{
	}

	public static bool IsLibraryInitialized()
	{
		return default(bool);
	}

	public static void FinalizeLibrary()
	{
	}

	public static void SetDecodeThreadPriorityAndroidExperimental(int prio)
	{
	}

	public static bool ShouldSampleRed(GraphicsDeviceType type, IntPtr tex_ptr)
	{
		return default(bool);
	}

	public static void Lock()
	{
	}

	public static void Unlock()
	{
	}

	private static extern void CRIWAREBBD8C621(int graphics_api, bool graphics_multi_threaded, int num_decoders, int num_of_max_entries);

	private static extern void CRIWAREA52DC80F();

	public static extern bool CRIWAREBB847967();

	private static extern void CRIWARE3466830B();

	public static extern void CRIWARED125A570(bool flag);

	public static extern void CRIWARE1A8362EB();

	public static extern void CRIWARE1AFDC46B();

	public static extern void criMana_UseStreamerManager(bool flag);

	public static extern bool criMana_IsStreamerManagerUsed();

	public static extern uint CRIWARE49F2A268();

	public static extern void criManaUnity_SetDecodeThreadPriority_ANDROID(int prio);

	private static extern void criManaUnity_SetConfigAdditionalParameters_ANDROID(bool enable_h264_playback);

	public static extern void criManaUnity_EnableSwitchTextureSampleColorGLES30_ANDROID();

	private static extern bool criManaUnity_ShouldSwitchTextureSampleColorToRedGLES30_ANDROID(IntPtr tex_ptr);
}
