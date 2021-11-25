using System;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeySoundData : CuttTimelineKeyTransformData, ICuttTimelineKeyHasColor
	{
		public enum FadeKind
		{
			Disable,
			Enable
		}

		public CuttTimelineSoundOperationID operationId;

		public string soundName;

		public int fadeFrame;

		public bool isEndStop;

		public int endStopFadeFrame;

		public static readonly float volumePercentBase;

		public static readonly float volumePercentMax;

		public float volumePercent;

		public FadeKind fadeKind;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}

		public Color GetRepresentativeColor()
		{
			return default(Color);
		}

		public float GetVolume()
		{
			return default(float);
		}
	}
}
