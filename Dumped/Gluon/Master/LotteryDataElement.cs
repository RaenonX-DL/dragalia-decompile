using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class LotteryDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _LotteryDate;

		[SerializeField]
		private string _ViewCloseDate;

		[SerializeField]
		private int _InformationId;

		[SerializeField]
		private int _InformationEndId;

		[SerializeField]
		private int _LotteryTicketId;

		public int Id => default(int);

		public string ViewStartDate => null;

		public string LotteryDate => null;

		public string ViewCloseDate => null;

		public int InformationId => default(int);

		public int InformationEndId => default(int);

		public int LotteryTicketId => default(int);
	}
}
