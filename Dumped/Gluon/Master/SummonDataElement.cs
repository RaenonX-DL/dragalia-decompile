using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class SummonDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Priority;

		[SerializeField]
		private SummonType _SummonType;

		[SerializeField]
		private string _SummonViewName;

		[SerializeField]
		private int _MaxSummonQuantity;

		[SerializeField]
		private string _CommenceDate;

		[SerializeField]
		private string _CompleteDate;

		[SerializeField]
		private int _SummonPointId;

		[SerializeField]
		private int _ExchangeSummonPoint;

		[SerializeField]
		private GiftType _GuaranteedEntityType;

		[SerializeField]
		private int _IsPickupGuaranteed;

		[SerializeField]
		private int _EncounterStoryId;

		[SerializeField]
		private string _SummonBgm;

		[SerializeField]
		private int _PickupNum;

		[SerializeField]
		private int _IsViewCover;

		[SerializeField]
		private int _PickupUnitType1;

		[SerializeField]
		private int _PickupUnitId1;

		[SerializeField]
		private int _PickupResourceId1;

		[SerializeField]
		private int _PickupUnitType2;

		[SerializeField]
		private int _PickupUnitId2;

		[SerializeField]
		private int _PickupResourceId2;

		[SerializeField]
		private int _PickupUnitType3;

		[SerializeField]
		private int _PickupUnitId3;

		[SerializeField]
		private int _PickupResourceId3;

		[SerializeField]
		private int _PickupUnitType4;

		[SerializeField]
		private int _PickupUnitId4;

		[SerializeField]
		private int _PickupResourceId4;

		[SerializeField]
		private string _MeetingStoryBanner;

		public int Id => default(int);

		public int Priority => default(int);

		public SummonType SummonType => default(SummonType);

		public string SummonViewName => null;

		public int MaxSummonQuantity => default(int);

		public string CommenceDate => null;

		public string CompleteDate => null;

		public int SummonPointId => default(int);

		public int ExchangeSummonPoint => default(int);

		public GiftType GuaranteedEntityType => default(GiftType);

		public int IsPickupGuaranteed => default(int);

		public int EncounterStoryId => default(int);

		public string SummonBgm => null;

		public int PickupNum => default(int);

		public int IsViewCover => default(int);

		public int PickupUnitType1 => default(int);

		public int PickupUnitId1 => default(int);

		public int PickupResourceId1 => default(int);

		public int PickupUnitType2 => default(int);

		public int PickupUnitId2 => default(int);

		public int PickupResourceId2 => default(int);

		public int PickupUnitType3 => default(int);

		public int PickupUnitId3 => default(int);

		public int PickupResourceId3 => default(int);

		public int PickupUnitType4 => default(int);

		public int PickupUnitId4 => default(int);

		public int PickupResourceId4 => default(int);

		public string MeetingStoryBanner => null;
	}
}
