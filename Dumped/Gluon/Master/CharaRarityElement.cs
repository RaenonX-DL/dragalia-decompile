using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CharaRarityElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _MaxLimitLevel;

		[SerializeField]
		private int _MaxLimitBreakCount;

		[SerializeField]
		private int _DuplicateDewPoint;

		[SerializeField]
		private int _MaxHpPlusCount;

		[SerializeField]
		private int _MaxAtkPlusCount;

		public int Id => default(int);

		public int MaxLimitLevel => default(int);

		public int MaxLimitBreakCount => default(int);

		public int DuplicateDewPoint => default(int);

		public int MaxHpPlusCount => default(int);

		public int MaxAtkPlusCount => default(int);
	}
}
