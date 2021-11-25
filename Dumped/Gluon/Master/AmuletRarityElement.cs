using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AmuletRarityElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _MaxLimitLevel;

		[SerializeField]
		private int _LimitLevel00;

		[SerializeField]
		private int _LimitLevel01;

		[SerializeField]
		private int _LimitLevel02;

		[SerializeField]
		private int _LimitLevel03;

		[SerializeField]
		private int _LimitLevel04;

		[SerializeField]
		private int _BuildupBaseExp;

		[SerializeField]
		private int _BuildupLevelExp;

		[SerializeField]
		private int _MaxHpPlusCount;

		[SerializeField]
		private int _MaxAtkPlusCount;

		public int Id => default(int);

		public int MaxLimitLevel => default(int);

		public int LimitLevel00 => default(int);

		public int LimitLevel01 => default(int);

		public int LimitLevel02 => default(int);

		public int LimitLevel03 => default(int);

		public int LimitLevel04 => default(int);

		public int BuildupBaseExp => default(int);

		public int BuildupLevelExp => default(int);

		public int MaxHpPlusCount => default(int);

		public int MaxAtkPlusCount => default(int);
	}
}
