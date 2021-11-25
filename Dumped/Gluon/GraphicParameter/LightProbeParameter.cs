using System;

namespace Gluon.GraphicParameter
{
	[Serializable]
	public class LightProbeParameter
	{
		public float lightProbeImpact;

		public float lightProbeOffset;

		public float lightProbeLuminanceMin;

		public float lightProbeLuminanceMax;

		public float lightProbeSaturationScale;

		public void Set(LightProbeParameter src)
		{
		}

		public void Set(float impact, float offset, float lummin, float lummax, float saturationScale)
		{
		}
	}
}
