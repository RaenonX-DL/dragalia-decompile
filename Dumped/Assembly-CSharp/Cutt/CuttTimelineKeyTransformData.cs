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
	public abstract class CuttTimelineKeyTransformData : CuttTimelineKeyWithInterpolate
	{
		// Fields
		public Vector3 position;
		public Vector3 rotation;
		public Vector3 scale;
	
		// Constructors
		protected CuttTimelineKeyTransformData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
		public Vector3 GetValuePosition(CuttTimelineControl timelineControl);
		public Vector3 GetValueRotation(CuttTimelineControl timelineControl);
		public Vector3 GetValueScale(CuttTimelineControl timelineControl);
	}
}
