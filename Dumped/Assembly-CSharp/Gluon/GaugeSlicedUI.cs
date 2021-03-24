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
	public class GaugeSlicedUI : MonoBehaviour
	{
		// Fields
		private float widthPixel;
		public float initWidthPixel;
		public float initWidth;
		public float ofsx;
		[SerializeField]
		private Transform trLeft;
		[SerializeField]
		private Transform trMid;
		[SerializeField]
		private Transform trRight;
		private float wLeft;
		private float wMid;
		private float wRight;
		private float ppu;
	
		// Properties
		public float Width { get; set; }
	
		// Constructors
		public GaugeSlicedUI();
	
		// Methods
		public void Initialize();
		private void SetWidth(float value);
	}
}
