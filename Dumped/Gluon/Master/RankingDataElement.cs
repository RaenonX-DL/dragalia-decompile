using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class RankingDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _GroupId;

		[SerializeField]
		private int _QuestId;

		[SerializeField]
		private string _RankingStartDate;

		[SerializeField]
		private string _RankingEndDate;

		[SerializeField]
		private string _RankingViewEndDate;

		public int Id => default(int);

		public int GroupId => default(int);

		public int QuestId => default(int);

		public string RankingStartDate => null;

		public string RankingEndDate => null;

		public string RankingViewEndDate => null;
	}
}
