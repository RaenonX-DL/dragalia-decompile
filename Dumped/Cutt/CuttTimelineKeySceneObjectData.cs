using System;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeySceneObjectData : CuttTimelineKeyTransformData, ICuttTimelineKeyHasColor
	{
		[Serializable]
		public class ObjectParamData
		{
			public string childName;

			public Transform targetNode;

			public bool activeSelf;

			public Vector3 localPosition;

			public Vector3 localRotation;

			public Vector3 localScale;

			public void SetData(ObjectParamData src)
			{
			}

			public void SetSceneObjectAccessData(ObjectParamData src)
			{
			}
		}

		public string rootObjectName;

		public Transform targetNode;

		public ObjectParamData[] objectParamDataArray;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}

		public Color GetRepresentativeColor()
		{
			return default(Color);
		}

		public bool IsChanged(CuttTimelineKeySceneObjectData targetData)
		{
			return default(bool);
		}

		public void SetData(CuttTimelineKeySceneObjectData targetData)
		{
		}

		public void SetSceneObjecttAccessData(CuttTimelineKeySceneObjectData targetData)
		{
		}

		public int GetParamNum()
		{
			return default(int);
		}

		private void AddParam()
		{
		}

		private void RemoveParam(int index)
		{
		}
	}
}
