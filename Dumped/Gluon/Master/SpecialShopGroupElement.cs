using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class SpecialShopGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _GoodsGroupName;

		[SerializeField]
		private int _Priority;

		public int Id => default(int);

		public string GoodsGroupName => null;

		public int Priority => default(int);
	}
}
