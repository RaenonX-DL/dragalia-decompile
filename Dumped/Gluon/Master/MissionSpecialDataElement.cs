using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MissionSpecialDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Text;

		[SerializeField]
		private int _MissionSpecialGroupId;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _CompleteValue;

		[SerializeField]
		private int _ProgressFlag;

		[SerializeField]
		private MissionTransportType _MissionTransportType;

		[SerializeField]
		private int _TransportValue;

		[SerializeField]
		private GiftType _EntityType;

		[SerializeField]
		private int _EntityId;

		[SerializeField]
		private int _EntityQuantity;

		public int Id => default(int);

		public string Text => null;

		public int MissionSpecialGroupId => default(int);

		public int SortId => default(int);

		public int CompleteValue => default(int);

		public int ProgressFlag => default(int);

		public MissionTransportType MissionTransportType => default(MissionTransportType);

		public int TransportValue => default(int);

		public GiftType EntityType => default(GiftType);

		public int EntityId => default(int);

		public int EntityQuantity => default(int);
	}
}
