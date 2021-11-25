using System;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyFadeData : CuttTimelineKeyWithInterpolate, ICuttTimelineKeyHasColor
	{
		public Color color;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public Color GetRepresentativeColor()
		{
			return default(Color);
		}

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}
	}
}
