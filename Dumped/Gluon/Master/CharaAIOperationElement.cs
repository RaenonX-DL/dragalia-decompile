using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CharaAIOperationElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private float _ActiveRange;

		[SerializeField]
		private float _HealSkillHpRatio;

		[SerializeField]
		private float _SkillProbability;

		[SerializeField]
		private float _ProbabilityInterval;

		public int Id => default(int);

		public float ActiveRange => default(float);

		public float HealSkillHpRatio => default(float);

		public float SkillProbability => default(float);

		public float ProbabilityInterval => default(float);
	}
}
