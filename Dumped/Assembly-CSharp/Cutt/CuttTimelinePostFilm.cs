/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.PostEffectParams;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelinePostFilm
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
		private CuttTimelineKeyPostFilmDataList _keys;
	
		// Constructors
		public CuttTimelinePostFilm();
	
		// Methods
		public void Initialize(CuttTimelineKeyPostFilmDataList keys, CuttTimelineControl timelineControl);
		public void AlterUpdate(float currentTime, float targetFps, int currentFrame);
	}
}
