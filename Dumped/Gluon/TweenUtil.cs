using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public static class TweenUtil
	{
		public struct ColorModulusArgs
		{
			public SpriteRenderer image;

			public MaterialPropertyBlock propertyBlock;

			public int propertyId;
		}

		private static bool isInitialize;

		private static List<Tweener> inGameTweenerList;

		public static void Init(bool isInGame)
		{
		}

		public static void SetDefaultTimeScaleIndependent(bool timeIndependent)
		{
		}

		public static Tweener ValueTo(float from, float to, float duration, [Optional] Action<float> callback)
		{
			return null;
		}

		public static Tweener ValueTo(Vector4 from, Vector4 to, float duration, [Optional] Action<Vector4> callback)
		{
			return null;
		}

		public static Tweener ValueTo(Vector3 from, Vector3 to, float duration, [Optional] Action<Vector3> callback)
		{
			return null;
		}

		public static Sequence ValueTo(float from, float to, float duration, float delay, [Optional] Action<float> callback)
		{
			return null;
		}

		public static Tweener AlphaTo(CanvasGroup canvasgroup, float from, float to, float duration)
		{
			return null;
		}

		public static Sequence AlphaTo(CanvasGroup canvasgroup, float from, float to, float duration, float delay)
		{
			return null;
		}

		public static Tweener Wait(float duration, [Optional] Action<float> callback)
		{
			return null;
		}

		public static Tweener ColorModulusTo(Image image, float from, float to, float duration, bool useCurrentFromValue, bool isAtlas)
		{
			return null;
		}

		public static Tweener DoExposure(ColorModulusArgs args, float fromEvBy255, float toEvBy255, float duration, bool isAtlas)
		{
			return null;
		}

		public static Tweener ColorModulusTo(ColorModulusArgs args, float from, float to, float duration, bool isAtlas)
		{
			return null;
		}

		public static void SetColorModulus(ColorModulusArgs args, float ev)
		{
		}

		public static Tweener DoExposure(ColorModulusArgs args, Vector4 fromEvBy255, Vector4 toEvBy255, float duration)
		{
			return null;
		}

		public static Tweener ColorModulusTo(ColorModulusArgs args, Vector4 from, Vector4 to, float duration)
		{
			return null;
		}

		public static void SetColorModulus(ColorModulusArgs args, Vector4 ev)
		{
		}

		public static Tweener DOTextInt(Text text, int initialValue, int finalValue, float duration, int digits)
		{
			return null;
		}

		public static string GetFormatText(int it, int digits)
		{
			return null;
		}

		public static void ReleaseInGameTweeners()
		{
		}

		public static Tweener ForInGame(this Tweener tweener)
		{
			return null;
		}
	}
}
