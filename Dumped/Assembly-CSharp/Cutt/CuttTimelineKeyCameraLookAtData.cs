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
	public class CuttTimelineKeyCameraLookAtData : CuttTimelineKeyWithInterpolate
	{
		// Fields
		public CuttCameraLookAtType lookAtType;
		public CuttCharaPositionFlag lookAtCharaPos;
		public CuttCameraLookAtCharaParts lookAtCharaParts;
		[NonSerialized]
		public Transform lookAtTransform;
		public string lookAtTransformName;
		public Vector3 rotation;
		public float eyeLength;
		public Vector3 offset;
		public Vector3[] bezierPoints;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyCameraLookAtData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
		public bool IsDelay();
		public bool IsDelayContinuous();
		public bool HasBezier();
		public int GetBezierPointCount();
		public Vector3 GetBezierPoint(int index, CuttTimelineControl timelineControl, Vector3 camPos);
		public Vector3 GetValue(CuttTimelineControl timelineControl, Vector3 camPos);
		private Vector3 GetValue(CuttTimelineControl timelineControl, CuttCameraLookAtType type, Vector3 camPos, bool containOffset);
	}
}
