using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class ShopCenterBannerElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _BannerTransportType;

		[SerializeField]
		private int _SlideBannerType;

		[SerializeField]
		private int _ViewGroupId;

		[SerializeField]
		private int _SlideBannerGroupId;

		[SerializeField]
		private int _BannerImageId;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _ShopType;

		[SerializeField]
		private int _GoodsId;

		[SerializeField]
		private int _PopupImageId;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		public int Id => default(int);

		public int BannerTransportType => default(int);

		public int SlideBannerType => default(int);

		public int ViewGroupId => default(int);

		public int SlideBannerGroupId => default(int);

		public int BannerImageId => default(int);

		public int SortId => default(int);

		public int ShopType => default(int);

		public int GoodsId => default(int);

		public int PopupImageId => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;
	}
}
