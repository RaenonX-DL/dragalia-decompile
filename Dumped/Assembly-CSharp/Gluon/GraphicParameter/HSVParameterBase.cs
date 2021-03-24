/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.GraphicParameter
{
	[Serializable]
	public class HSVParameterBase : IShaderData<HSVParameterBase>
	{
		// Fields
		[Range]
		[SerializeField]
		[Tooltip]
		private float hue;
		[Range]
		[SerializeField]
		[Tooltip]
		private float saturation;
		[Range]
		[SerializeField]
		[Tooltip]
		private float value;
		[CompilerGenerated]
		private Matrix4x4 _parameterMatrix_k__BackingField;
	
		// Properties
		public Matrix4x4 parameterMatrix { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public HSVParameterBase();
	
		// Methods
		public float GetHue();
		public void SetHue(float f);
		public float GetSaturation();
		public void SetSaturation(float f);
		public float GetValue();
		public void SetValue(float f);
		public bool isTrueColor();
		public virtual void UpdateParameterMatrix();
		public static void Lerp(ref HSVParameterBase o, HSVParameterBase a, HSVParameterBase b, float t);
		public void Copy(HSVParameterBase src);
	}
}
