using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SamplingCPU : MonoBehaviour
	{
		private class CpuInfo
		{
			public int cpuMaxFreq;

			public int cpuMinFreq;

			public int scalingCurFreq;

			public string coreNoList;
		}

		[SerializeField]
		private float _samplingMargin;

		[SerializeField]
		private Text outputText;

		private List<CpuInfo> _cpuInfo;

		private float _nowCount;

		private void CheckActive()
		{
		}

		private void Start()
		{
		}

		private void SamplingAllData()
		{
		}

		private bool ReadAllLines(string path, out string[] arrText, int retrycount = 10)
		{
			return default(bool);
		}

		private void SamplingCurrentData()
		{
		}

		private string Freq2Text(int freq)
		{
			return null;
		}

		private void CreateText()
		{
		}

		private void Update()
		{
		}
	}
}
