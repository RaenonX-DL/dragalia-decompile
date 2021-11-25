using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AbilityCrestRarityElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _MaxLimitLevelByLimitBreak0;

		[SerializeField]
		private int _MaxLimitLevelByLimitBreak1;

		[SerializeField]
		private int _MaxLimitLevelByLimitBreak2;

		[SerializeField]
		private int _MaxLimitLevelByLimitBreak3;

		[SerializeField]
		private int _MaxLimitLevelByLimitBreak4;

		[SerializeField]
		private int _MaxHpPlusCount;

		[SerializeField]
		private int _MaxAtkPlusCount;

		public int Id => default(int);

		public int MaxLimitLevelByLimitBreak0 => default(int);

		public int MaxLimitLevelByLimitBreak1 => default(int);

		public int MaxLimitLevelByLimitBreak2 => default(int);

		public int MaxLimitLevelByLimitBreak3 => default(int);

		public int MaxLimitLevelByLimitBreak4 => default(int);

		public int MaxHpPlusCount => default(int);

		public int MaxAtkPlusCount => default(int);
	}
}
