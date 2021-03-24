/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public static class CriAtomPlugin
{
	// Fields
	private static int initializationCount;
	private static List<IntPtr> effectInterfaceList;
	private static bool isConfigured;
	private static float timeSinceStartup;
	private static CriWare.CpuUsage cpuUsage;
	private static int CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT;
	private static ushort CRIATOMPARAMETER2_ID_INVALID;
	private static ulong temporalStorage;

	// Properties
	public static bool isInitialized { get; }

	// Nested types
	[UnmanagedFunctionPointer]
	public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1);

	// Constructors
	static CriAtomPlugin();

	// Methods
	public static void Log(string log);
	public static bool GetAudioEffectInterfaceList(out List<IntPtr> effect_interface_list);
	private static IntPtr GetSpatializerCoreInterfaceFromAtomOculusAudioBridge();
	public static void SetConfigParameters(int max_virtual_voices, int max_voice_limit_groups, int max_categories, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int num_buses, bool vr_mode);
	public static void SetConfigAdditionalParameters_PC(long buffering_time_pc);
	public static void SetConfigAdditionalParameters_LINUX(CriAtomConfig.LinuxOutput output);
	public static void SetConfigAdditionalParameters_IOS(uint buffering_time_ios, bool override_ipod_music_ios);
	public static void SetConfigAdditionalParameters_ANDROID(int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, IntPtr android_context);
	public static void SetConfigAdditionalParameters_VITA(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, int num_mana_decoders);
	public static void SetConfigAdditionalParameters_PS4(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, bool use_audio3d, int num_audio3d_memory_voices, int num_audio3d_streaming_voices);
	public static void SetConfigAdditionalParameters_WEBGL(int num_webaudio_voices);
	public static void SetMaxSamplingRateForStandardVoicePool(int sampling_rate_for_memory, int sampling_rate_for_streaming);
	public static int GetRequiredMaxVirtualVoices(CriAtomConfig atomConfig);
	public static void InitializeLibrary();
	public static bool IsLibraryInitialized();
	public static void FinalizeLibrary();
	public static void Pause(bool pause);
	public static CriWare.CpuUsage GetCpuUsage();
	public static ushort GetLoopCountParameterId();
	public static void DecryptAcb(IntPtr acb_hn, ulong key, ulong nonce);
	[MonoPInvokeCallback]
	private static ulong CallbackFromNative(IntPtr ptr1);
	private static extern void CRIWARECF844BF2(int max_virtual_voices, int max_voice_limit_groups, int max_categories, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int num_buses, bool use_ambisonics, IntPtr spatializer_core_interface);
	private static extern void CRIWAREA488071D(long buffering_time_pc);
	private static extern void CRIWARED5F9F6BA(int output);
	private static extern void CRIWARED811A639(uint buffering_time_ios, bool override_ipod_music_ios);
	private static extern void CRIWAREA5BB5FA6(int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, IntPtr android_context);
	private static extern void CRIWAREA4B00AC3();
	public static extern bool CRIWARE3F266E57();
	private static extern void CRIWARED210699A();
	private static extern void CRIWAREBEE6E504(bool pause);
	public static extern uint CRIWARE9A240609();
	public static extern void CRIWAREC7716020(int code);
	public static extern void CRIWAREB7275AD5(IntPtr cbfunc, string separator_string);
	public static extern void CRIWARE6ED0E9C8();
	public static extern void CRIWARE488451A3(IntPtr cbfunc);
	public static extern void CRIWARED81F3597();
	private static extern void CRIWARE88FC8CD0(int sampling_rate_for_memory, int sampling_rate_for_streaming);
	public static extern void CRIWARE4E36730F();
	public static extern void CRIWAREF498208E();
	public static extern void CRIWARE86280B26(IntPtr acb_hn, CallbackFromNativeDelegate func, IntPtr obj);
	public static extern ushort CRIWARECA140BA3(int id);
}

