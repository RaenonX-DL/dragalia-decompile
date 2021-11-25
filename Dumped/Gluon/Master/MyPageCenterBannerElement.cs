using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MyPageCenterBannerElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _BannerType;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _EventId;

		[SerializeField]
		private int _TransportTargetId;

		[SerializeField]
		private string _BannerImageName;

		[SerializeField]
		private int _ReleaseQuestStoryId;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		public int Id => default(int);

		public int BannerType => default(int);

		public int SortId => default(int);

		public int EventId => default(int);

		public int TransportTargetId => default(int);

		public string BannerImageName => null;

		public int ReleaseQuestStoryId => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;
	}
}
