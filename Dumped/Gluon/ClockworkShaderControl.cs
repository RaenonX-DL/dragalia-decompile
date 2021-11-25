using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class ClockworkShaderControl : FastUpdateMonoBehaviour
	{
		private Material targetMaterial;

		private float lightRatio;

		private const float minDotProductLimit = -1.01f;

		public float LightRatio => default(float);

		public void SetMaterial(Material mat)
		{
		}

		public void SetLightColor(Color32 col)
		{
		}

		public void SetDarkColor(float contrast, float saturation, float brightness)
		{
		}

		public void SetLightRatio(float f)
		{
		}

		private void UpdateMaterialParameter()
		{
		}

		public void ResetMaterialParameter()
		{
		}

		public static void ResetMaterialParameter(Material mat)
		{
		}
	}
}
