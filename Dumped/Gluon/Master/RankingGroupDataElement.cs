using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class RankingGroupDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _RankingTierGroupId;

		[SerializeField]
		private string _RankingStartDate;

		[SerializeField]
		private string _RankingEndDate;

		[SerializeField]
		private string _RankingViewEndDate;

		[SerializeField]
		private int _IsUseDecimalNumber;

		public int Id => default(int);

		public int RankingTierGroupId => default(int);

		public string RankingStartDate => null;

		public string RankingEndDate => null;

		public string RankingViewEndDate => null;

		public int IsUseDecimalNumber => default(int);
	}
}
