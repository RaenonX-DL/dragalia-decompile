using System;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyHandShakeData : CuttTimelineKeyWithInterpolate
	{
		public bool enable;

		public bool isOverwrite;

		public float positionFrequency;

		public float rotationFrequency;

		public float positionAmount;

		public float rotationAmount;

		public Vector3 positionComponents;

		public Vector3 rotationComponents;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}
	}
}
