using System;
using Gluon;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyFogData : CuttTimelineKeyWithInterpolate
	{
		public bool EnableFog;

		public bool ChangeColor;

		public bool ChangeDistance;

		public Color FogColor;

		public FogMode DistanceFogMode;

		public float FogStart;

		public float FogEnd;

		public float FogDensity;

		public bool enableHeightFog;

		public PostEffectGlobalFog.HeightFogParam heightFogParam;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);
	}
}
