using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeDungeonItemDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Rarity;

		[SerializeField]
		private DmodeDungeonItemType _DmodeDungeonItemType;

		[SerializeField]
		private int _DungeonItemTargetId;

		[SerializeField]
		private int _UseCount;

		[SerializeField]
		private int _SellDmodePoint1;

		[SerializeField]
		private int _SellDmodePoint2;

		public int Id => default(int);

		public int Rarity => default(int);

		public DmodeDungeonItemType DmodeDungeonItemType => default(DmodeDungeonItemType);

		public int DungeonItemTargetId => default(int);

		public int UseCount => default(int);

		public int SellDmodePoint1 => default(int);

		public int SellDmodePoint2 => default(int);
	}
}
