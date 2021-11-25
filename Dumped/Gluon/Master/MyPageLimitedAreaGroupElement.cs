using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MyPageLimitedAreaGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _LimitedPeriodType;

		[SerializeField]
		private int _EventId;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		public int Id => default(int);

		public int SortId => default(int);

		public int LimitedPeriodType => default(int);

		public int EventId => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;
	}
}
