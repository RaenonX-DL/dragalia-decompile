using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class TalismanDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private int _BaseHp;

		[SerializeField]
		private int _BaseAtk;

		[SerializeField]
		private int _TalismanCharaId;

		[SerializeField]
		private int _SellCoin;

		public int Id => default(int);

		public string Name => null;

		public int BaseHp => default(int);

		public int BaseAtk => default(int);

		public int TalismanCharaId => default(int);

		public int SellCoin => default(int);
	}
}
