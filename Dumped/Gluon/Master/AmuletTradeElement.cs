using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AmuletTradeElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _AmuletId;

		[SerializeField]
		private int _NeedDewPoint1;

		[SerializeField]
		private int _NeedDewPoint2;

		[SerializeField]
		private int _NeedDewPoint3;

		[SerializeField]
		private int _NeedDewPoint4;

		[SerializeField]
		private int _NeedDewPoint5;

		[SerializeField]
		private int _Priority;

		[SerializeField]
		private int _Limit;

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

		public int AmuletId => default(int);

		public int NeedDewPoint1 => default(int);

		public int NeedDewPoint2 => default(int);

		public int NeedDewPoint3 => default(int);

		public int NeedDewPoint4 => default(int);

		public int NeedDewPoint5 => default(int);

		public int Priority => default(int);

		public int Limit => default(int);

		public string CommenceDate => null;

		public string CompleteDate => null;

		public string PickupViewStartDate => null;

		public string PickupViewEndDate => null;

		public int MemoryPickupEventId => default(int);
	}
}
