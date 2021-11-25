using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BattleRoyalEnemyElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _BaseEnemyParamId;

		[SerializeField]
		private int _CanEnterBush;

		[SerializeField]
		private int _ItemGroupId00;

		[SerializeField]
		private int _ItemGroupId01;

		[SerializeField]
		private int _ItemGroupId02;

		[SerializeField]
		private int _ItemGroupId03;

		[SerializeField]
		private int _ItemGroupId04;

		[SerializeField]
		private int _ItemGroupId05;

		[SerializeField]
		private int _ItemGroupId06;

		[SerializeField]
		private int _ItemGroupId07;

		[SerializeField]
		private int _NeedsPopMsg;

		public int Id => default(int);

		public int BaseEnemyParamId => default(int);

		public int CanEnterBush => default(int);

		public int ItemGroupId00 => default(int);

		public int ItemGroupId01 => default(int);

		public int ItemGroupId02 => default(int);

		public int ItemGroupId03 => default(int);

		public int ItemGroupId04 => default(int);

		public int ItemGroupId05 => default(int);

		public int ItemGroupId06 => default(int);

		public int ItemGroupId07 => default(int);

		public int NeedsPopMsg => default(int);
	}
}
