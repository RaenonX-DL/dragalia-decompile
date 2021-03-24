/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.PostEffectParams
{
	[Serializable]
	public class TiltShiftParam
	{
		// Fields
		[Tooltip]
		public bool isDebugMode;
		[Range]
		[Tooltip]
		public float resolutionScale;
		[Range]
		[Tooltip]
		public float blurArea;
		[Range]
		[Tooltip]
		public float blurPower;
		[Range]
		[Tooltip]
		public float blurOffset;
		[Range]
		[Tooltip]
		public float blurBaseUp;
		[Tooltip]
		public PointIrisSetting[] pointIrisSettings;
		[Range]
		[Tooltip]
		public float pointIrisCutout;
	
		// Nested types
		[Serializable]
		public struct PointIrisSetting
		{
			// Fields
			[Range]
			[Tooltip]
			public float pointIrisCenterX;
			[Range]
			[Tooltip]
			public float pointIrisCenterY;
			[Range]
			[Tooltip]
			public float pointIrisRadiusX;
			[Range]
			[Tooltip]
			public float pointIrisRadiusY;
		}
	
		// Constructors
		public TiltShiftParam();
	
		// Methods
		public void setPointIrisSetting(int index, float centerX, float centerY, float radiusX, float radiusY);
	}
}
