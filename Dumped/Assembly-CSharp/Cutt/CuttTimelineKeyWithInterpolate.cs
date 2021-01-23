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
	public abstract class CuttTimelineKeyWithInterpolate : CuttTimelineKey
	{
		// Fields
		public CuttCameraInterpolateType interpolateType;
		public AnimationCurve curve;
		public CuttTimelineEasing.Type easingType;
	
		// Constructors
		protected CuttTimelineKeyWithInterpolate();
	
		// Methods
		public override bool IsInterpolateKey();
	}
}
