using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class WeaponCraftGroupSeriesElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _CraftGroupName;

		[SerializeField]
		private int _SortId;

		public int Id => default(int);

		public string CraftGroupName => null;

		public int SortId => default(int);
	}
}
