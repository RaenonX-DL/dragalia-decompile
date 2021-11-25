using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DamageDampingElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private float _DampingCoef;

		[SerializeField]
		private int _Combo;

		[SerializeField]
		private int _HumanSkill;

		[SerializeField]
		private int _DragonSkillLevel1;

		[SerializeField]
		private int _DragonSkillLevel2;

		public int Id => default(int);

		public float DampingCoef => default(float);

		public int Combo => default(int);

		public int HumanSkill => default(int);

		public int DragonSkillLevel1 => default(int);

		public int DragonSkillLevel2 => default(int);
	}
}
