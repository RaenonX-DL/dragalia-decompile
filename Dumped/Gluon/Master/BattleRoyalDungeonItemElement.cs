using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BattleRoyalDungeonItemElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _PrefabName;

		[SerializeField]
		private int _Param;

		[SerializeField]
		private int _TakenEffectTrigger;

		[SerializeField]
		private string _TakenSE;

		public int Id => default(int);

		public string PrefabName => null;

		public int Param => default(int);

		public int TakenEffectTrigger => default(int);

		public string TakenSE => null;
	}
}
