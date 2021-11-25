using System;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCharacterTransformData : CuttTimelineKeyTransformData
	{
		public bool active;

		public Vector3 shadowOffset;

		public Vector2 shadowScale;

		public bool isBillboard;

		public bool isUseAlpha;

		public float alpha;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}
	}
}
