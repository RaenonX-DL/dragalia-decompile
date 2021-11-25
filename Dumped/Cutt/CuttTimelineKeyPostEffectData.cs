using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyPostEffectData : CuttTimelineKeyWithInterpolate
	{
		public float blurSize;

		public bool isEnableDiffusionColor;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}
	}
}
