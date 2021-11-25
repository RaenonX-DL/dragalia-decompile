using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCameraSwitcherData : CuttTimelineKey
	{
		public int cameraIndex;

		public string stateName;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}
	}
}
