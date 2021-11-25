using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AmuletLimitBreakElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _AmuletQuantity1;

		[SerializeField]
		private int _AmuletQuantity2;

		[SerializeField]
		private int _AmuletQuantity3;

		[SerializeField]
		private int _AmuletQuantity4;

		public int Id => default(int);

		public int AmuletQuantity1 => default(int);

		public int AmuletQuantity2 => default(int);

		public int AmuletQuantity3 => default(int);

		public int AmuletQuantity4 => default(int);
	}
}
