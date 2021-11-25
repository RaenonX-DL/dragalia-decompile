using System.Runtime.CompilerServices;
using CriWare;
using UnityEngine;

namespace Cute.Cri
{
	public class AudioOutPutAnalyzer : MonoBehaviour
	{
		private const int ChannelL = 0;

		private const int ChannelR = 1;

		private const int AnalyzedDspBusId = 0;

		private const int SpectrumAnalyzerBands = 128;

		private BusAnalyzer busAnalyzer;

		private float[] spectrumLevels;

		private static bool isInitialized;

		private static AudioOutPutAnalyzer instance;

		public CriAtomExOutputAnalyzer OutputAnalyzer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float[] SpectrumLevels => null;

		public float PeakLevelL
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float PeakLevelR
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float DBL
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float DBR
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static AudioOutPutAnalyzer Instance => null;

		public void Initialize()
		{
		}

		public static void AttachToAnalyzer(CriAtomSource criAtomSource)
		{
		}

		public static void DetachFromAnalyzer(CriAtomSource criAtomSource)
		{
		}

		private void Update()
		{
		}

		private void UpdateBusInfo()
		{
		}

		private void UpdateSpectrumLine()
		{
		}

		private void Destroy()
		{
		}
	}
}
