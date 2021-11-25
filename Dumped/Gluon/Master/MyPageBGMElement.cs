using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MyPageBGMElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _BgmId;

		[SerializeField]
		private string _BgmName;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		[SerializeField]
		private int _ReleaseQuestStoryId;

		[SerializeField]
		private int _IsForceSetting;

		public int Id => default(int);

		public int BgmId => default(int);

		public string BgmName => null;

		public int SortId => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;

		public int ReleaseQuestStoryId => default(int);

		public int IsForceSetting => default(int);
	}
}
