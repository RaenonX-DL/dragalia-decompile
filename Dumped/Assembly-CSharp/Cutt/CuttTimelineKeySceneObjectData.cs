/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeySceneObjectData : CuttTimelineKeyTransformData, ICuttTimelineKeyHasColor
	{
		// Fields
		public string rootObjectName;
		public Transform targetNode;
		public ObjectParamData[] objectParamDataArray;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Nested types
		[Serializable]
		public class ObjectParamData
		{
			// Fields
			public string childName;
			public Transform targetNode;
			public bool activeSelf;
			public Vector3 localPosition;
			public Vector3 localRotation;
			public Vector3 localScale;
	
			// Constructors
			public ObjectParamData();
	
			// Methods
			public void SetData(ObjectParamData src);
			public void SetSceneObjectAccessData(ObjectParamData src);
		}
	
		// Constructors
		public CuttTimelineKeySceneObjectData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
		public Color GetRepresentativeColor();
		public bool IsChanged(CuttTimelineKeySceneObjectData targetData);
		public void SetData(CuttTimelineKeySceneObjectData targetData);
		public void SetSceneObjecttAccessData(CuttTimelineKeySceneObjectData targetData);
		public int GetParamNum();
		private void AddParam();
		private void RemoveParam(int index);
	}
}
