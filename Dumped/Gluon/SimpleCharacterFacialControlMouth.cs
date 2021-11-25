using System;
using UnityEngine;

namespace Gluon
{
	public class SimpleCharacterFacialControlMouth : SimpleCharacterFacialControl
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

		protected CharaFaceMouth curFaceMouth;

		private Work work;

		protected override void OnSetup(out Vector2 defaultOffset)
		{
		}

		protected override bool OnLateUpdate(out Vector2 outTextureOffset)
		{
			return default(bool);
		}

		public override void SetFaceMouth(CharaFaceMouth faceMouth)
		{
		}

		private void SetFaceMouthData(CharaFaceMouth faceMouth)
		{
		}
	}
}
