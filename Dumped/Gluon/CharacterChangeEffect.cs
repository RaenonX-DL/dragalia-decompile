using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class CharacterChangeEffect : FastUpdateMonoBehaviour
	{
		private CharacterSelector owner;

		private CharacterSelector target;

		private EffectObject effect;

		private Vector3 startPoint;

		private Vector3 relayPoint;

		private Vector3 endPoint;

		private float elapsedTime;

		private float durationTime;

		public static CharacterChangeEffect Create(CharacterSelector src, CharacterSelector dst)
		{
			return null;
		}

		public void Initialize(CharacterSelector src, CharacterSelector dst)
		{
		}

		public override void FastUpdate()
		{
		}

		private Vector3 CalcPoint(float step)
		{
			return default(Vector3);
		}
	}
}
