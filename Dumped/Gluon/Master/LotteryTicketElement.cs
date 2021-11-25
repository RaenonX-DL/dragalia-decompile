using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class LotteryTicketElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _Description;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _LotteryId;

		[SerializeField]
		private string _ViewStartTime;

		[SerializeField]
		private string _ViewEndTime;

		public int Id => default(int);

		public string Name => null;

		public string Description => null;

		public int SortId => default(int);

		public int LotteryId => default(int);

		public string ViewStartTime => null;

		public string ViewEndTime => null;
	}
}
