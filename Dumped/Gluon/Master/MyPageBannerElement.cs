using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MyPageBannerElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _BannerType;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _SpecialShopId;

		[SerializeField]
		private int _ViewDayCount;

		[SerializeField]
		private int _EventId;

		[SerializeField]
		private int _QuestGroupId;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		public int Id => default(int);

		public int BannerType => default(int);

		public int SortId => default(int);

		public int SpecialShopId => default(int);

		public int ViewDayCount => default(int);

		public int EventId => default(int);

		public int QuestGroupId => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;
	}
}
