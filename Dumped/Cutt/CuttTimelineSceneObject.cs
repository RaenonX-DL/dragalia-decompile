using System.Collections.Generic;
using UnityEngine;

namespace Cutt
{
	public class CuttTimelineSceneObject
	{
		private CuttTimelineKeySceneObjectDataList _keys;

		private CuttTimelineControl _timelineControl;

		private CuttTimelineKeySceneObjectData logData;

		public void Initialize(CuttTimelineKeySceneObjectDataList keys, CuttTimelineControl timelineControl)
		{
		}

		public void AlterUpdate(float currentTime, float targetFps, int currentFrame)
		{
		}

		private Transform GetSceneObject(CuttTimelineKeySceneObjectData targetKey)
		{
			return null;
		}

		private Transform GetChildNode(Transform rootNode, string targetName)
		{
			return null;
		}

		private void SetSceneObjectParam(Transform rootNode, List<CuttTimelineKeySceneObjectData.ObjectParamData> paramList)
		{
		}
	}
}
