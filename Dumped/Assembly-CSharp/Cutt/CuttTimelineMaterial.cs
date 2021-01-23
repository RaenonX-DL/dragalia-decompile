/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelineMaterial
	{
		// Fields
		private CuttTimelineKeyMaterialDataList _keys;
		private CuttTimelineControl _timelineControl;
		private Material targetMaterial;
		private CuttTimelineKeyMaterialData logData;
	
		// Constructors
		public CuttTimelineMaterial();
	
		// Methods
		public void Initialize(CuttTimelineKeyMaterialDataList keys, CuttTimelineControl timelineControl);
		public void AlterUpdate(float currentTime, float targetFps, int currentFrame);
		private Material GetMaterial(CuttTimelineKeyMaterialData targetKey);
		public Transform FindTransform(GameObject rootObj, string name);
		private void SetMaterialParam(Material targetMat, List<CuttTimelineKeyMaterialData.ShaderParamData> paramList);
	}
}
