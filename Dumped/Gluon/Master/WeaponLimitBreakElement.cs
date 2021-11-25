using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class WeaponLimitBreakElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _WeaponQuantity1;

		[SerializeField]
		private int _WeaponQuantity2;

		[SerializeField]
		private int _WeaponQuantity3;

		[SerializeField]
		private int _WeaponQuantity4;

		public int Id => default(int);

		public int WeaponQuantity1 => default(int);

		public int WeaponQuantity2 => default(int);

		public int WeaponQuantity3 => default(int);

		public int WeaponQuantity4 => default(int);
	}
}
