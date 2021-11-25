using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestCarryDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _CarryGroupName;

		[SerializeField]
		private int _TargetGroupId;

		[SerializeField]
		private int _MaxReceiveCount;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private string _StartDate;

		[SerializeField]
		private string _EndDate;

		[SerializeField]
		private GiftType _CarryEntityType1;

		[SerializeField]
		private int _CarryEntityId1;

		[SerializeField]
		private int _CarryEntityQuantity1;

		[SerializeField]
		private GiftType _CarryEntityType2;

		[SerializeField]
		private int _CarryEntityId2;

		[SerializeField]
		private int _CarryEntityQuantity2;

		[SerializeField]
		private GiftType _CarryEntityType3;

		[SerializeField]
		private int _CarryEntityId3;

		[SerializeField]
		private int _CarryEntityQuantity3;

		public int Id => default(int);

		public string CarryGroupName => null;

		public int TargetGroupId => default(int);

		public int MaxReceiveCount => default(int);

		public int SortId => default(int);

		public string StartDate => null;

		public string EndDate => null;

		public GiftType CarryEntityType1 => default(GiftType);

		public int CarryEntityId1 => default(int);

		public int CarryEntityQuantity1 => default(int);

		public GiftType CarryEntityType2 => default(GiftType);

		public int CarryEntityId2 => default(int);

		public int CarryEntityQuantity2 => default(int);

		public GiftType CarryEntityType3 => default(GiftType);

		public int CarryEntityId3 => default(int);

		public int CarryEntityQuantity3 => default(int);
	}
}
