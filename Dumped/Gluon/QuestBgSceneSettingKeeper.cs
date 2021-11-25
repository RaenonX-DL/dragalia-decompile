using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class QuestBgSceneSettingKeeper : MonoBehaviour
	{
		[Header("Fog")]
		public bool fog;

		public FogMode fogMode;

		public Color fogColor;

		public float fogStartDistance;

		public float fogEndDistance;

		[Header("DOF_QuestSelect")]
		public float dofFocalSize;

		public float dofFocalLength;

		public float dofSmoothness;

		[Header("DOF_QuestPrepare")]
		public float dofQpFocalSize;

		public float dofQpFocalLength;

		public float dofQpSmoothness;

		[Header("ReflectionMap")]
		public Cubemap reflectionCubeMap;

		public float intensityMultiplier;

		private void SaveCurrentFogSetting()
		{
		}

		public void ReflectSavedSetting([Optional] PostEffect pe, bool isUseQuestPrepareSetting = false)
		{
		}
	}
}
