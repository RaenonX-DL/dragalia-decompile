using System;
using UnityEngine;

namespace Gluon.PostEffectParams
{
	[Serializable]
	public class ColorCollectParam
	{
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

		public void UpdateParameters()
		{
		}

		public void SetChannel(AnimationCurve r, AnimationCurve g, AnimationCurve b)
		{
		}

		public void SetDepthChannel(AnimationCurve r, AnimationCurve g, AnimationCurve b)
		{
		}
	}
}
