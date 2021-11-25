using System;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCuttEventData : CuttTimelineKey, ICuttTimelineKeyHasColor
	{
		public CuttEventType cuttEventType;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}

		public Color GetRepresentativeColor()
		{
			return default(Color);
		}
	}
}
