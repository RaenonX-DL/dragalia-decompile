using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestGuestDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _CharaId;

		[SerializeField]
		private int _CharaLevel;

		[SerializeField]
		private int _DragonId;

		[SerializeField]
		private int _DragonLevel;

		[SerializeField]
		private int _WeaponId;

		[SerializeField]
		private int _WeaponLevel;

		[SerializeField]
		private int _WeaponBodyId;

		[SerializeField]
		private int _WeaponBodyBuildup;

		[SerializeField]
		private int _AmuletId;

		[SerializeField]
		private int _AmuletLevel;

		[SerializeField]
		private int _Amulet2Id;

		[SerializeField]
		private int _Amulet2Level;

		[SerializeField]
		private int _AiType;

		[SerializeField]
		private int _IsEnemyTarget;

		public int Id => default(int);

		public int CharaId => default(int);

		public int CharaLevel => default(int);

		public int DragonId => default(int);

		public int DragonLevel => default(int);

		public int WeaponId => default(int);

		public int WeaponLevel => default(int);

		public int WeaponBodyId => default(int);

		public int WeaponBodyBuildup => default(int);

		public int AmuletId => default(int);

		public int AmuletLevel => default(int);

		public int Amulet2Id => default(int);

		public int Amulet2Level => default(int);

		public int AiType => default(int);

		public int IsEnemyTarget => default(int);
	}
}
