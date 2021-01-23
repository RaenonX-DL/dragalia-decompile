/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyRichShaderData : CuttTimelineKeyWithInterpolate
	{
		// Fields
		[Tooltip]
		public Color toonGlobalShadowColor;
		[Tooltip]
		public Color toonGlobalShadowGlowColor;
		[Tooltip]
		public HSVParameterBase toonCommonEdgeShadowHSV;
		[Tooltip]
		public Vector3 toonLightParamRoatate;
		[Tooltip]
		public float outlineWidthClampMin;
		[Tooltip]
		public float outlineWidthClampMax;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyRichShaderData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
		public CuttTimelineKey Interpolate(CuttTimelineKey interpKey, CuttTimelineKey prevKey, float t);
	}
}
