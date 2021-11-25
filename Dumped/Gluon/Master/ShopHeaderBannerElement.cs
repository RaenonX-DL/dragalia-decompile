using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class ShopHeaderBannerElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _ShopCategoryNum;

		[SerializeField]
		private int _BannerImageId;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _ShopType;

		[SerializeField]
		private int _GoodsId;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		public int Id => default(int);

		public int ShopCategoryNum => default(int);

		public int BannerImageId => default(int);

		public int SortId => default(int);

		public int ShopType => default(int);

		public int GoodsId => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;
	}
}
