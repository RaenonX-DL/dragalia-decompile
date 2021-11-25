using System.Collections.Generic;
using UnityEngine;

namespace Cutt
{
	public class CuttTimelineMaterial
	{
		private CuttTimelineKeyMaterialDataList _keys;

		private CuttTimelineControl _timelineControl;

		private Material targetMaterial;

		private CuttTimelineKeyMaterialData logData;

		public void Initialize(CuttTimelineKeyMaterialDataList keys, CuttTimelineControl timelineControl)
		{
		}

		public void AlterUpdate(float currentTime, float targetFps, int currentFrame)
		{
		}

		private Material GetMaterial(CuttTimelineKeyMaterialData targetKey)
		{
			return null;
		}

		public Transform FindTransform(GameObject rootObj, string name)
		{
			return null;
		}

		private void SetMaterialParam(Material targetMat, List<CuttTimelineKeyMaterialData.ShaderParamData> paramList)
		{
		}
	}
}
