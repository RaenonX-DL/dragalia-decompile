using Gluon.PostEffectParams;
using UnityEngine;

namespace Cutt
{
	public class CuttTimelinePostFilm
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

		private CuttTimelineKeyPostFilmDataList _keys;

		public void Initialize(CuttTimelineKeyPostFilmDataList keys, CuttTimelineControl timelineControl)
		{
		}

		public void AlterUpdate(float currentTime, float targetFps, int currentFrame)
		{
		}
	}
}
