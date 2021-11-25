using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class OutDungeonAreaDesignerDataElement : IMasterElement
	{
		[SerializeField]
		private string _Area;

		[SerializeField]
		private string _BgColor;

		[SerializeField]
		private string _SilhouetteBaseColor;

		[SerializeField]
		private string _SilhouetteRimColor;

		[SerializeField]
		private string _ObjectShadowColor;

		[SerializeField]
		private float _ObjectShadowColorPower;

		[SerializeField]
		private float _LightProbeImpact0;

		[SerializeField]
		private float _LightProbeOffset0;

		[SerializeField]
		private float _LightProbeLumMin0;

		[SerializeField]
		private float _LightProbeLumMax0;

		[SerializeField]
		private float _LightProbeSatScale0;

		[SerializeField]
		private float _LightProbeImpact1;

		[SerializeField]
		private float _LightProbeOffset1;

		[SerializeField]
		private float _LightProbeLumMin1;

		[SerializeField]
		private float _LightProbeLumMax1;

		[SerializeField]
		private float _LightProbeSatScale1;

		[SerializeField]
		private float _LightProbeImpact2;

		[SerializeField]
		private float _LightProbeOffset2;

		[SerializeField]
		private float _LightProbeLumMin2;

		[SerializeField]
		private float _LightProbeLumMax2;

		[SerializeField]
		private float _LightProbeSatScale2;

		[SerializeField]
		private float _LightProbeImpact3;

		[SerializeField]
		private float _LightProbeOffset3;

		[SerializeField]
		private float _LightProbeLumMin3;

		[SerializeField]
		private float _LightProbeLumMax3;

		[SerializeField]
		private float _LightProbeSatScale3;

		[SerializeField]
		private float _BlurSize;

		[SerializeField]
		private float _BlurArea;

		[SerializeField]
		private float _BlurPower;

		[SerializeField]
		private float _BlurOffset;

		[SerializeField]
		private float _BlurBaseup;

		[SerializeField]
		private float _BloomWeight;

		[SerializeField]
		private float _BloomThreshold;

		[SerializeField]
		private float _BloomIntensity;

		public string Area => null;

		public string BgColor => null;

		public string SilhouetteBaseColor => null;

		public string SilhouetteRimColor => null;

		public string ObjectShadowColor => null;

		public float ObjectShadowColorPower => default(float);

		public float LightProbeImpact0 => default(float);

		public float LightProbeOffset0 => default(float);

		public float LightProbeLumMin0 => default(float);

		public float LightProbeLumMax0 => default(float);

		public float LightProbeSatScale0 => default(float);

		public float LightProbeImpact1 => default(float);

		public float LightProbeOffset1 => default(float);

		public float LightProbeLumMin1 => default(float);

		public float LightProbeLumMax1 => default(float);

		public float LightProbeSatScale1 => default(float);

		public float LightProbeImpact2 => default(float);

		public float LightProbeOffset2 => default(float);

		public float LightProbeLumMin2 => default(float);

		public float LightProbeLumMax2 => default(float);

		public float LightProbeSatScale2 => default(float);

		public float LightProbeImpact3 => default(float);

		public float LightProbeOffset3 => default(float);

		public float LightProbeLumMin3 => default(float);

		public float LightProbeLumMax3 => default(float);

		public float LightProbeSatScale3 => default(float);

		public float BlurSize => default(float);

		public float BlurArea => default(float);

		public float BlurPower => default(float);

		public float BlurOffset => default(float);

		public float BlurBaseup => default(float);

		public float BloomWeight => default(float);

		public float BloomThreshold => default(float);

		public float BloomIntensity => default(float);
	}
}
