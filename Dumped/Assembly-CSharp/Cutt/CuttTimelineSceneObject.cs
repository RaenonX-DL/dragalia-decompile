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
	public class CuttTimelineSceneObject
	{
		// Fields
		private CuttTimelineKeySceneObjectDataList _keys;
		private CuttTimelineControl _timelineControl;
		private CuttTimelineKeySceneObjectData logData;
	
		// Constructors
		public CuttTimelineSceneObject();
	
		// Methods
		public void Initialize(CuttTimelineKeySceneObjectDataList keys, CuttTimelineControl timelineControl);
		public void AlterUpdate(float currentTime, float targetFps, int currentFrame);
		private Transform GetSceneObject(CuttTimelineKeySceneObjectData targetKey);
		private Transform GetChildNode(Transform rootNode, string targetName);
		private void SetSceneObjectParam(Transform rootNode, List<CuttTimelineKeySceneObjectData.ObjectParamData> paramList);
	}
}
