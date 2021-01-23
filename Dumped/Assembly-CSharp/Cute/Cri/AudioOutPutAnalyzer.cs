/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public class AudioOutPutAnalyzer : MonoBehaviour
	{
		// Fields
		private const int ChannelL = 0;
		private const int ChannelR = 1;
		private const int AnalyzedDspBusId = 0;
		private const int SpectrumAnalyzerBands = 128;
		[CompilerGenerated]
		private CriAtomExOutputAnalyzer _OutputAnalyzer_k__BackingField;
		private BusAnalyzer busAnalyzer;
		private float[] spectrumLevels;
		[CompilerGenerated]
		private float _PeakLevelL_k__BackingField;
		[CompilerGenerated]
		private float _PeakLevelR_k__BackingField;
		[CompilerGenerated]
		private float _DBL_k__BackingField;
		[CompilerGenerated]
		private float _DBR_k__BackingField;
		private static bool isInitialized;
		private static AudioOutPutAnalyzer instance;
	
		// Properties
		public CriAtomExOutputAnalyzer OutputAnalyzer { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float[] SpectrumLevels { get; }
		public float PeakLevelL { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float PeakLevelR { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float DBL { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float DBR { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static AudioOutPutAnalyzer Instance { get; }
	
		// Constructors
		public AudioOutPutAnalyzer();
		static AudioOutPutAnalyzer();
	
		// Methods
		public void Initialize();
		public static void AttachToAnalyzer(CriAtomSource criAtomSource);
		public static void DetachFromAnalyzer(CriAtomSource criAtomSource);
		private void Update();
		private void UpdateBusInfo();
		private void UpdateSpectrumLine();
		private void Destroy();
	}
}
