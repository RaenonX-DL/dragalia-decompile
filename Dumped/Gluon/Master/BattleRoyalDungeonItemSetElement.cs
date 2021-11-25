using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BattleRoyalDungeonItemSetElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private Gluon.BattleRoyalDungeonItem _Item0;

		[SerializeField]
		private Gluon.BattleRoyalDungeonItem _Item1;

		[SerializeField]
		private Gluon.BattleRoyalDungeonItem _Item2;

		[SerializeField]
		private Gluon.BattleRoyalDungeonItem _Item3;

		[SerializeField]
		private Gluon.BattleRoyalDungeonItem _Item4;

		public int Id => default(int);

		public Gluon.BattleRoyalDungeonItem Item0 => default(Gluon.BattleRoyalDungeonItem);

		public Gluon.BattleRoyalDungeonItem Item1 => default(Gluon.BattleRoyalDungeonItem);

		public Gluon.BattleRoyalDungeonItem Item2 => default(Gluon.BattleRoyalDungeonItem);

		public Gluon.BattleRoyalDungeonItem Item3 => default(Gluon.BattleRoyalDungeonItem);

		public Gluon.BattleRoyalDungeonItem Item4 => default(Gluon.BattleRoyalDungeonItem);
	}
}
