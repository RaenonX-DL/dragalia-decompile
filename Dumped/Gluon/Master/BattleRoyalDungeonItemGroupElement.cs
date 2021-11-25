using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BattleRoyalDungeonItemGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private Gluon.BattleRoyalDungeonItemSet _ConditionItemSet0;

		[SerializeField]
		private int _ConditionMinCount0;

		[SerializeField]
		private Gluon.BattleRoyalDungeonItemSet _ConditionItemSet1;

		[SerializeField]
		private int _ConditionMinCount1;

		[SerializeField]
		private Gluon.BattleRoyalDungeonItemSet _ConditionItemSet2;

		[SerializeField]
		private int _ConditionMinCount2;

		[SerializeField]
		private Gluon.BattleRoyalDungeonItemSet _ItemSet0;

		[SerializeField]
		private int _Probability0;

		[SerializeField]
		private Gluon.BattleRoyalDungeonItemSet _ItemSet1;

		[SerializeField]
		private int _Probability1;

		[SerializeField]
		private Gluon.BattleRoyalDungeonItemSet _ItemSet2;

		[SerializeField]
		private int _Probability2;

		[SerializeField]
		private Gluon.BattleRoyalDungeonItemSet _ItemSet3;

		[SerializeField]
		private int _Probability3;

		[SerializeField]
		private Gluon.BattleRoyalDungeonItemSet _ItemSet4;

		[SerializeField]
		private int _Probability4;

		public int Id => default(int);

		public Gluon.BattleRoyalDungeonItemSet ConditionItemSet0 => default(Gluon.BattleRoyalDungeonItemSet);

		public int ConditionMinCount0 => default(int);

		public Gluon.BattleRoyalDungeonItemSet ConditionItemSet1 => default(Gluon.BattleRoyalDungeonItemSet);

		public int ConditionMinCount1 => default(int);

		public Gluon.BattleRoyalDungeonItemSet ConditionItemSet2 => default(Gluon.BattleRoyalDungeonItemSet);

		public int ConditionMinCount2 => default(int);

		public Gluon.BattleRoyalDungeonItemSet ItemSet0 => default(Gluon.BattleRoyalDungeonItemSet);

		public int Probability0 => default(int);

		public Gluon.BattleRoyalDungeonItemSet ItemSet1 => default(Gluon.BattleRoyalDungeonItemSet);

		public int Probability1 => default(int);

		public Gluon.BattleRoyalDungeonItemSet ItemSet2 => default(Gluon.BattleRoyalDungeonItemSet);

		public int Probability2 => default(int);

		public Gluon.BattleRoyalDungeonItemSet ItemSet3 => default(Gluon.BattleRoyalDungeonItemSet);

		public int Probability3 => default(int);

		public Gluon.BattleRoyalDungeonItemSet ItemSet4 => default(Gluon.BattleRoyalDungeonItemSet);

		public int Probability4 => default(int);
	}
}
