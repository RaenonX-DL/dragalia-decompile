using System;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyFloorColorData : CuttTimelineKeyWithInterpolate, ICuttTimelineKeyHasColor
	{
		public Color _color;

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
