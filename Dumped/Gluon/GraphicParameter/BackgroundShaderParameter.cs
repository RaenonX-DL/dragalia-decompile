using System;
using UnityEngine;

namespace Gluon.GraphicParameter
{
	[Serializable]
	public class BackgroundShaderParameter
	{
		public Color shadowColor;

		public float shadowColorPower;

		public LightProbeParameter[] lightProbeParamArray;

		private LightProbeParameter GetLightProbeParameter(string materialName)
		{
			return null;
		}

		public void SetShaderParameter()
		{
		}

		public void SetLightProbeParamToMaterial(Material material)
		{
		}

		public void SetLightProbeParamToMaterial(Material material, LightProbeParamCategory lightProbeParamCategory)
		{
		}

		public void SetLightProbeParamToPropetyBlock(string materialName, MaterialPropertyBlock materialPropertyBlock)
		{
		}

		public void SetRenderersLightProbeParamToMaterials(Renderer[] renderers)
		{
		}

		public void SetRenderersLightProbeParamToMaterials(GameObject obj, bool useSharedMaterial)
		{
		}
	}
}
