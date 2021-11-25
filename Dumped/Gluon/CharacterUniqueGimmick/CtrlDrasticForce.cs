using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlDrasticForce : CUGCtrlBase
	{
		public const int STACK_MAX = 30;

		private float _duration;

		private float _timer;

		public const CharaCircleGaugeUI.Type CIRCLE_GAUGE_TYPE = CharaCircleGaugeUI.Type.DrasticForce;

		public List<float> dmgRate
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int stackNum
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override bool active => default(bool);

		public bool isReady => default(bool);

		private Transform transform => null;

		public void Setup(CharacterSelector selector, float duration, int[] arrayForceRate, int stackSize)
		{
		}

		private void Reset()
		{
		}

		public override void ResetState()
		{
		}

		public override void Update(CharacterBase src)
		{
		}

		public override void OnDead()
		{
		}

		public void AddStack(int value, bool resetTime = false)
		{
		}

		public float GetDamageRate()
		{
			return default(float);
		}
	}
}
