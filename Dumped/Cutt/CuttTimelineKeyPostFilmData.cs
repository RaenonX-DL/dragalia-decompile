using System;
using Gluon.PostEffectParams;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyPostFilmData : CuttTimelineKeyWithInterpolate
	{
		public PostFilmMode filmMode;

		public PostColorType colorType;

		public float filmPower;

		public Vector2 filmOffsetParam;

		public Vector4 filmOptionParam;

		public Color color0;

		public Color color1;

		public Color color2;

		public Color color3;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}
	}
}
