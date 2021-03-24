/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCameraPositionData : CuttTimelineKeyWithInterpolate
	{
		// Fields
		public CuttCameraPositionType setType;
		public Vector3 posDirect;
		[NonSerialized]
		public Transform posTransform;
		public string posTransformName;
		public Vector3 offset;
		public Vector3[] bezierPoints;
		public CuttCharaPositionFlag charaRelativeBase;
		public CuttCameraLookAtCharaParts charaRelativeParts;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyCameraPositionData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
		public bool IsDelay();
		public bool IsDelayContinuous();
		public bool HasBezier();
		public int GetBezierPointCount();
		public Vector3 GetBezierPoint(int index, CuttTimelineControl timelineControl);
		public Vector3 GetValue(CuttTimelineControl timelineControl);
		private Vector3 GetValue(CuttTimelineControl timelineControl, CuttCameraPositionType type, bool containOffset);
	}
}
