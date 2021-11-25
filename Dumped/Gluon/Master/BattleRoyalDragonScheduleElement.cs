using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BattleRoyalDragonScheduleElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _DragonId;

		[SerializeField]
		private string _StartDate;

		[SerializeField]
		private string _EndDate;

		public int Id => default(int);

		public int DragonId => default(int);

		public string StartDate => null;

		public string EndDate => null;
	}
}
