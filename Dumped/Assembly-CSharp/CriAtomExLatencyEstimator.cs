/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public static class CriAtomExLatencyEstimator
{
	// Nested types
	public enum Status
	{
		Stop = 0,
		Processing = 1,
		Done = 2,
		Error = 3
	}

	public struct EstimatorInfo
	{
		// Fields
		public Status status;
		public uint estimated_latency;
	}

	// Methods
	public static void InitializeModule();
	public static void FinalizeModule();
	public static EstimatorInfo GetCurrentInfo();
	private static extern void criAtomLatencyEstimator_Initialize_ANDROID();
	private static extern void criAtomLatencyEstimator_Finalize_ANDROID();
	private static extern EstimatorInfo criAtomLatencyEstimator_GetCurrentInfo_ANDROID();
}

