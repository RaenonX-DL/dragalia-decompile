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
	public class ColorCollectParam
	{
		// Fields
		public bool isRgbSync;
		public AnimationCurve channelRed;
		public AnimationCurve channelGreen;
		public AnimationCurve channelBlue;
		public AnimationCurve channelDepthRed;
		public AnimationCurve channelDepthGreen;
		public AnimationCurve channelDepthBlue;
		public float saturation;
		public bool isDebugUpdateTextures;
		public Texture2D rgbChannelTex;
		public Texture2D rgbDepthChannelTex;
		public bool isUpdateTexturesOnStartup;
	
		// Constructors
		public ColorCollectParam();
	
		// Methods
		public void UpdateParameters();
		public void SetChannel(AnimationCurve r, AnimationCurve g, AnimationCurve b);
		public void SetDepthChannel(AnimationCurve r, AnimationCurve g, AnimationCurve b);
	}
}
