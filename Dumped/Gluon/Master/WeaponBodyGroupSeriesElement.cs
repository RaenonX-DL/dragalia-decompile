using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class WeaponBodyGroupSeriesElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _GroupSeriesName;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _SeriesLockType;

		[SerializeField]
		private string _SeriesLockText;

		public int Id => default(int);

		public string GroupSeriesName => null;

		public int SortId => default(int);

		public int SeriesLockType => default(int);

		public string SeriesLockText => null;
	}
}
