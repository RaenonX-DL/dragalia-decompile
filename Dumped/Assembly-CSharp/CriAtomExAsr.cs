/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriAtomExAsr
{
	// Nested types
	private struct BusAnalyzerConfig
	{
		// Fields
		public int interval;
		public int peakHoldTime;
	}

	public struct BusAnalyzerInfo
	{
		// Fields
		public int numChannels;
		public float[] rmsLevels;
		public float[] peakLevels;
		public float[] peakHoldLevels;

		// Constructors
		public BusAnalyzerInfo(byte[] data);
	}

	// Constructors
	public CriAtomExAsr();

	// Methods
	public static void AttachBusAnalyzer(string busName, int interval, int peakHoldTime);
	public static void AttachBusAnalyzer(int interval, int peakHoldTime);
	public static void DetachBusAnalyzer(string busName);
	public static void DetachBusAnalyzer();
	public static void GetBusAnalyzerInfo(string busName, out BusAnalyzerInfo info);
	[Obsolete]
	public static void GetBusAnalyzerInfo(int busId, out BusAnalyzerInfo info);
	public static void SetBusVolume(string busName, float volume);
	[Obsolete]
	public static void SetBusVolume(int busId, float volume);
	public static void SetBusSendLevel(string busName, string sendTo, float level);
	[Obsolete]
	public static void SetBusSendLevel(int busId, int sendTo, float level);
	public static void SetBusMatrix(string busName, int inputChannels, int outputChannels, float[] matrix);
	[Obsolete]
	public static void SetBusMatrix(int busId, int inputChannels, int outputChannels, float[] matrix);
	public static void SetEffectBypass(string busName, string effectName, bool bypass);
	public static void SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue);
	public static float GetEffectParameter(string busName, string effectName, uint parameterIndex);
	public static bool RegisterEffectInterface(IntPtr afx_interface);
	public static void UnregisterEffectInterface(IntPtr afx_interface);
	private static extern void criAtomExAsr_AttachBusAnalyzerByName(string busName, ref BusAnalyzerConfig config);
	private static extern void criAtomExAsr_AttachBusAnalyzer(int busNo, ref BusAnalyzerConfig config);
	private static extern void criAtomExAsr_DetachBusAnalyzerByName(string busName);
	private static extern void criAtomExAsr_DetachBusAnalyzer(int busNo);
	private static extern void criAtomExAsr_GetBusAnalyzerInfoByName(string busName, IntPtr info);
	private static extern void criAtomExAsr_GetBusAnalyzerInfo(int busNo, IntPtr info);
	private static extern void criAtomExAsr_SetBusVolumeByName(string busName, float volume);
	private static extern void criAtomExAsr_SetBusVolume(int busNo, float volume);
	private static extern void criAtomExAsr_SetBusSendLevelByName(string busName, string sendtoName, float level);
	private static extern void criAtomExAsr_SetBusSendLevel(int busNo, int sendtoNo, float level);
	private static extern void criAtomExAsr_SetBusMatrixByName(string busName, int inputChannels, int outputChannels, float[] matrix);
	private static extern void criAtomExAsr_SetBusMatrix(int busNo, int inputChannels, int outputChannels, float[] matrix);
	private static extern void criAtomExAsr_SetEffectBypass(string busName, string effectName, bool bypass);
	private static extern void criAtomExAsr_UpdateEffectParameters(string busName, string effectName);
	private static extern void criAtomExAsr_SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue);
	private static extern float criAtomExAsr_GetEffectParameter(string busName, string effectName, uint parameterIndex);
	private static extern bool criAtomExAsr_RegisterEffectInterface(IntPtr afx_interface);
	private static extern void criAtomExAsr_UnregisterEffectInterface(IntPtr afx_interface);
}

