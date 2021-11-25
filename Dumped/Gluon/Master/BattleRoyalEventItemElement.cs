using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BattleRoyalEventItemElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _EventId;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _Detail;

		[SerializeField]
		private BattleRoyalEventItemType _EventItemType;

		[SerializeField]
		private Gluon.WeaponType _TargetWeaponType;

		[SerializeField]
		private int _TargetCharaId;

		[SerializeField]
		private DetailLinkType _DetailLinkType;

		[SerializeField]
		private int _MoveQuest1;

		[SerializeField]
		private int _MoveQuest2;

		[SerializeField]
		private int _MoveQuest3;

		[SerializeField]
		private int _MoveQuest4;

		[SerializeField]
		private int _MoveQuest5;

		[SerializeField]
		private string _Description;

		[SerializeField]
		private int _PouchRarity;

		public int Id => default(int);

		public int EventId => default(int);

		public string Name => null;

		public string Detail => null;

		public BattleRoyalEventItemType EventItemType => default(BattleRoyalEventItemType);

		public Gluon.WeaponType TargetWeaponType => default(Gluon.WeaponType);

		public int TargetCharaId => default(int);

		public DetailLinkType DetailLinkType => default(DetailLinkType);

		public int MoveQuest1 => default(int);

		public int MoveQuest2 => default(int);

		public int MoveQuest3 => default(int);

		public int MoveQuest4 => default(int);

		public int MoveQuest5 => default(int);

		public string Description => null;

		public int PouchRarity => default(int);
	}
}
