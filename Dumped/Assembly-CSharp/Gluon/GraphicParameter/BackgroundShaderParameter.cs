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
	public class BackgroundShaderParameter
	{
		// Fields
		public Color shadowColor;
		public float shadowColorPower;
		public LightProbeParameter[] lightProbeParamArray;
	
		// Constructors
		public BackgroundShaderParameter();
	
		// Methods
		private LightProbeParameter GetLightProbeParameter(string materialName);
		public void SetShaderParameter();
		public void SetLightProbeParamToMaterial(Material material);
		public void SetLightProbeParamToMaterial(Material material, LightProbeParamCategory lightProbeParamCategory);
		public void SetLightProbeParamToPropetyBlock(string materialName, MaterialPropertyBlock materialPropertyBlock);
		public void SetRenderersLightProbeParamToMaterials(Renderer[] renderers);
		public void SetRenderersLightProbeParamToMaterials(GameObject obj, bool useSharedMaterial);
	}
}
