/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ClockworkShaderControl : FastUpdateMonoBehaviour
	{
		// Fields
		private Material targetMaterial;
		private float lightRatio;
		private const float minDotProductLimit = -1.01f;
	
		// Properties
		public float LightRatio { get; }
	
		// Constructors
		public ClockworkShaderControl();
	
		// Methods
		public void SetMaterial(Material mat);
		public void SetLightColor(Color32 col);
		public void SetDarkColor(float contrast, float saturation, float brightness);
		public void SetLightRatio(float f);
		private void UpdateMaterialParameter();
		public void ResetMaterialParameter();
		public static void ResetMaterialParameter(Material mat);
	}
}
