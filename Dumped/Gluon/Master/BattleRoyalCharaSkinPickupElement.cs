using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BattleRoyalCharaSkinPickupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _BattleRoyalCharaId;

		[SerializeField]
		private int _SummonId;

		[SerializeField]
		private string _PickupStartDate;

		[SerializeField]
		private string _PickupEndDate;

		public int Id => default(int);

		public int BattleRoyalCharaId => default(int);

		public int SummonId => default(int);

		public string PickupStartDate => null;

		public string PickupEndDate => null;
	}
}
