using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class WeaponCraftGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private Gluon.WeaponType _CraftWeaponType;

		[SerializeField]
		private string _CraftGroupName;

		[SerializeField]
		private int _CraftSeriesId;

		[SerializeField]
		private string _CraftSeriesImage;

		[SerializeField]
		private string _CraftHeaderImage;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _PickupEventId;

		[SerializeField]
		private string _PickupStartDate;

		[SerializeField]
		private string _PickupEndDate;

		public int Id => default(int);

		public Gluon.WeaponType CraftWeaponType => default(Gluon.WeaponType);

		public string CraftGroupName => null;

		public int CraftSeriesId => default(int);

		public string CraftSeriesImage => null;

		public string CraftHeaderImage => null;

		public int SortId => default(int);

		public int PickupEventId => default(int);

		public string PickupStartDate => null;

		public string PickupEndDate => null;
	}
}
