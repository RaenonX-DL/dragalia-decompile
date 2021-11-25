using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DragonLimitBreakElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _DragonQuantity1;

		[SerializeField]
		private int _DragonQuantity2;

		[SerializeField]
		private int _DragonQuantity3;

		[SerializeField]
		private int _DragonQuantity4;

		[SerializeField]
		private int _LimitBreakMaterialQuantity1;

		[SerializeField]
		private int _LimitBreakMaterialQuantity2;

		[SerializeField]
		private int _LimitBreakMaterialQuantity3;

		[SerializeField]
		private int _LimitBreakMaterialQuantity4;

		[SerializeField]
		private int _LimitBreakMaterialQuantity5;

		public int Id => default(int);

		public int DragonQuantity1 => default(int);

		public int DragonQuantity2 => default(int);

		public int DragonQuantity3 => default(int);

		public int DragonQuantity4 => default(int);

		public int LimitBreakMaterialQuantity1 => default(int);

		public int LimitBreakMaterialQuantity2 => default(int);

		public int LimitBreakMaterialQuantity3 => default(int);

		public int LimitBreakMaterialQuantity4 => default(int);

		public int LimitBreakMaterialQuantity5 => default(int);
	}
}
