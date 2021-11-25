using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AbilityCrestTradeElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _AbilityCrestId;

		[SerializeField]
		private int _NeedDewPoint;

		[SerializeField]
		private int _Priority;

		[SerializeField]
		private int _LabelType;

		[SerializeField]
		private string _CommenceDate;

		[SerializeField]
		private string _CompleteDate;

		[SerializeField]
		private string _PickupViewStartDate;

		[SerializeField]
		private string _PickupViewEndDate;

		[SerializeField]
		private int _MemoryPickupEventId;

		public int Id => default(int);

		public int AbilityCrestId => default(int);

		public int NeedDewPoint => default(int);

		public int Priority => default(int);

		public int LabelType => default(int);

		public string CommenceDate => null;

		public string CompleteDate => null;

		public string PickupViewStartDate => null;

		public string PickupViewEndDate => null;

		public int MemoryPickupEventId => default(int);
	}
}
