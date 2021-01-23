/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.PostEffectParams
{
	[Serializable]
	public class PostFilmParam
	{
		// Fields
		[Tooltip]
		public PostFilmMode filmMode;
		[Tooltip]
		public float filmPower;
		[Tooltip]
		public Vector2 filmOffsetParam;
		[Tooltip]
		public float vignetteIntensity;
		[Tooltip]
		public float vignetteDecrement;
		[Tooltip]
		public Color filmColor0;
		[Tooltip]
		public Color filmColor1;
		[Tooltip]
		public Color filmColor2;
		[Tooltip]
		public Color filmColor3;
	
		// Constructors
		public PostFilmParam();
	
		// Methods
		public void SetColorAll(Color color);
	}
}
