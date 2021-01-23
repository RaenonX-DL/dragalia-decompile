/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.GraphicParameter
{
	[Serializable]
	public class LightProbeParameter
	{
		// Fields
		[Range]
		public float lightProbeImpact;
		[Range]
		public float lightProbeOffset;
		[Range]
		public float lightProbeLuminanceMin;
		[Range]
		public float lightProbeLuminanceMax;
		[Range]
		public float lightProbeSaturationScale;
	
		// Constructors
		public LightProbeParameter();
	
		// Methods
		public void Set(LightProbeParameter src);
		public void Set(float impact, float offset, float lummin, float lummax, float saturationScale);
	}
}
