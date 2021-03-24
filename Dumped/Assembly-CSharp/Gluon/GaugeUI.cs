/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GaugeUI : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private GaugeSlicedUI gaugeFrame;
		[SerializeField]
		private GaugeSlicedUI gaugeDiff;
		[SerializeField]
		private GaugeSlicedUI gaugeCurrent;
		[SerializeField]
		private GaugeSlicedUI gaugeDanger;
	
		// Constructors
		public GaugeUI();
	
		// Methods
		public void Initialize();
		public void SetValue(float v);
	}
}
