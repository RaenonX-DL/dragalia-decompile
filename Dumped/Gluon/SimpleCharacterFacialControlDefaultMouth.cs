using System;
using UnityEngine;

namespace Gluon
{
	public class SimpleCharacterFacialControlDefaultMouth : SimpleCharacterFacialControlBase
	{
		public class Work
		{
			private float mouthTime;

			public float mouthFrame;

			public int mouthFrameCount;

			public Func<int, int> getNextIndex16Func;

			public void Clear()
			{
			}

			public bool OnUpdate(out Vector2 outTextureOffset, float deltaTime)
			{
				return default(bool);
			}
		}

		private Work work;

		protected override void OnSetup(out Vector2 defaultOffset)
		{
		}

		protected override bool OnLateUpdate(out Vector2 outTextureOffset)
		{
			return default(bool);
		}
	}
}
