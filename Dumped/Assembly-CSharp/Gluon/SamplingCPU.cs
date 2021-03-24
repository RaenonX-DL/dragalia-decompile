/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SamplingCPU : MonoBehaviour
	{
		// Fields
		[Range]
		[SerializeField]
		private float _samplingMargin;
		[SerializeField]
		private UnityEngine.UI.Text outputText;
		private List<CpuInfo> _cpuInfo;
		private float _nowCount;
	
		// Nested types
		private class CpuInfo
		{
			// Fields
			public int cpuMaxFreq;
			public int cpuMinFreq;
			public int scalingCurFreq;
			public string coreNoList;
	
			// Constructors
			public CpuInfo();
		}
	
		// Constructors
		public SamplingCPU();
	
		// Methods
		private void CheckActive();
		private void Start();
		private void SamplingAllData();
		private bool ReadAllLines(string path, out string[] arrText, int retrycount = 10);
		private void SamplingCurrentData();
		private string Freq2Text(int freq);
		private void CreateText();
		private void Update();
	}
}
