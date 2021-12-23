using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeServitorPassiveLevelElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _PassiveNum;

		[SerializeField]
		private string _PassiveDetail;

		[SerializeField]
		private int _Level;

		[SerializeField]
		private float _UpValue;

		[SerializeField]
		private GiftType _ReleaseEntityType1;

		[SerializeField]
		private int _ReleaseEntityId1;

		[SerializeField]
		private int _ReleaseEntityQuantity1;

		[SerializeField]
		private GiftType _ReleaseEntityType2;

		[SerializeField]
		private int _ReleaseEntityId2;

		[SerializeField]
		private int _ReleaseEntityQuantity2;

		[SerializeField]
		private GiftType _ReleaseEntityType3;

		[SerializeField]
		private int _ReleaseEntityId3;

		[SerializeField]
		private int _ReleaseEntityQuantity3;

		public int Id => default(int);

		public int PassiveNum => default(int);

		public string PassiveDetail => null;

		public int Level => default(int);

		public float UpValue => default(float);

		public GiftType ReleaseEntityType1 => default(GiftType);

		public int ReleaseEntityId1 => default(int);

		public int ReleaseEntityQuantity1 => default(int);

		public GiftType ReleaseEntityType2 => default(GiftType);

		public int ReleaseEntityId2 => default(int);

		public int ReleaseEntityQuantity2 => default(int);

		public GiftType ReleaseEntityType3 => default(GiftType);

		public int ReleaseEntityId3 => default(int);

		public int ReleaseEntityQuantity3 => default(int);
	}
}
