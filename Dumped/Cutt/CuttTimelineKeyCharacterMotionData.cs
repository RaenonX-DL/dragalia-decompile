using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCharacterMotionData : CuttTimelineKey
	{
		public string stateName;

		public bool isRandom;

		public float minRandomSec;

		public float maxRandomSec;

		public float intervalRatio;

		public bool trigger;

		public string triggerName;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}
	}
}
