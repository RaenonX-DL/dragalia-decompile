using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CommonReportCategoryElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private string _CategoryName;

		public int Id => default(int);

		public int SortId => default(int);

		public string CategoryName => null;
	}
}
