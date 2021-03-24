/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.PostEffectParams;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyPostFilmData : CuttTimelineKeyWithInterpolate
	{
		// Fields
		public PostFilmMode filmMode;
		public PostColorType colorType;
		public float filmPower;
		public Vector2 filmOffsetParam;
		public Vector4 filmOptionParam;
		public Color color0;
		public Color color1;
		public Color color2;
		public Color color3;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyPostFilmData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
	}
}
