using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class ShopBannerElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _ViewGroup;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _ShopType;

		[SerializeField]
		private int _GoodsId;

		[SerializeField]
		private int _TopBannerImageId;

		[SerializeField]
		private int _PopupImageId;

		public int Id => default(int);

		public int ViewGroup => default(int);

		public int SortId => default(int);

		public int ShopType => default(int);

		public int GoodsId => default(int);

		public int TopBannerImageId => default(int);

		public int PopupImageId => default(int);
	}
}
