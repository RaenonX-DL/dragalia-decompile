using System;
using UnityEngine;

namespace Gluon
{
	public class SimpleCharacterFacialControlDefaultEye : SimpleCharacterFacialControlBase
	{
		public struct Work
		{
			public float faceBlinkTime;

			public float faceBlinkInterval;

			public int faceBlinkIndex;

			public void Clear()
			{
			}

			public bool OnUpdate(out Vector2 outTextureOffset, float deltaTime)
			{
				return default(bool);
			}
		}

		private static readonly float[] blinkOffset;

		private const float blinkFrame = 71f / (678f * (float)Math.PI);

		private Work work;

		protected override void OnSetup(out Vector2 defaultTextureOffset)
		{
		}

		protected override bool OnLateUpdate(out Vector2 outTextureOffset)
		{
			return default(bool);
		}
	}
}
