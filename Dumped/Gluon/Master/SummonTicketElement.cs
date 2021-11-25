using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class SummonTicketElement : IMasterElement
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
		private int _ListViewType;

		[SerializeField]
		private int _DrawType;

		[SerializeField]
		private SummonType _SummonType;

		[SerializeField]
		private int _SummonId;

		[SerializeField]
		private int _LimitType;

		[SerializeField]
		private int _LimitTime;

		[SerializeField]
		private string _CommenceDate;

		[SerializeField]
		private string _CompleteDate;

		public int Id => default(int);

		public string Name => null;

		public string Description => null;

		public int SortId => default(int);

		public int ListViewType => default(int);

		public int DrawType => default(int);

		public SummonType SummonType => default(SummonType);

		public int SummonId => default(int);

		public int LimitType => default(int);

		public int LimitTime => default(int);

		public string CommenceDate => null;

		public string CompleteDate => null;
	}
}
