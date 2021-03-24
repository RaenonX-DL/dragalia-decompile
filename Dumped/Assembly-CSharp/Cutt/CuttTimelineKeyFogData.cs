/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyFogData : CuttTimelineKeyWithInterpolate
	{
		// Fields
		public bool EnableFog;
		public bool ChangeColor;
		public bool ChangeDistance;
		public Color FogColor;
		public FogMode DistanceFogMode;
		public float FogStart;
		public float FogEnd;
		public float FogDensity;
		public bool enableHeightFog;
		public PostEffectGlobalFog.HeightFogParam heightFogParam;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyFogData();
	}
}
