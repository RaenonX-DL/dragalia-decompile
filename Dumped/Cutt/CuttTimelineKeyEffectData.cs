using System;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyEffectData : CuttTimelineKeyTransformData
	{
		public CuttTimelineEffectOperationID operationId;

		public string effectName;

		public int trigger;

		public CuttCharacterInitializer.CharacterId attachCharacterId;

		public string attachName;

		public bool isAttachPosition;

		public bool isAttachRotation;

		public Vector3 attachOffset;

		public CuttLayer.Type layerType;

		public bool ignoreGeneralOffset;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}
	}
}
