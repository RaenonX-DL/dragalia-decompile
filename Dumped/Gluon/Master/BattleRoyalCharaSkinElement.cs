using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BattleRoyalCharaSkinElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _BaseCharaId;

		[SerializeField]
		private int _SpecialSkillId;

		[SerializeField]
		private int _UnlockMaterialId;

		[SerializeField]
		private int _UnlockCommonMaterialQuantity;

		[SerializeField]
		private int _UnlockPickupMaterialQuantity;

		[SerializeField]
		private string _ReleaseStartDate;

		[SerializeField]
		private string _ReleaseEndDate;

		[SerializeField]
		private int _IsUnlockTrade;

		[SerializeField]
		private string _AnimController;

		public int Id => default(int);

		public int BaseCharaId => default(int);

		public int SpecialSkillId => default(int);

		public int UnlockMaterialId => default(int);

		public int UnlockCommonMaterialQuantity => default(int);

		public int UnlockPickupMaterialQuantity => default(int);

		public string ReleaseStartDate => null;

		public string ReleaseEndDate => null;

		public int IsUnlockTrade => default(int);

		public string AnimController => null;
	}
}
