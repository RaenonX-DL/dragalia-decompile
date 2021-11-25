using System;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCharaMotionData : CuttTimelineKey
	{
		public string motionName;

		public AnimationClip clip;

		public float motionHeadTime;

		public float playLength;

		public float playSpeed;

		public bool loop;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}
	}
}
