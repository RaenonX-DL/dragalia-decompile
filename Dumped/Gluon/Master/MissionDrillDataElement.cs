using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MissionDrillDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _TextTitle;

		[SerializeField]
		private string _TextDetail;

		[SerializeField]
		private string _IconImage;

		[SerializeField]
		private int _MissionDrillGroupId;

		[SerializeField]
		private int _Step;

		[SerializeField]
		private int _IsPickUp;

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

		[SerializeField]
		private int _NeedCompleteMissionId;

		public int Id => default(int);

		public string TextTitle => null;

		public string TextDetail => null;

		public string IconImage => null;

		public int MissionDrillGroupId => default(int);

		public int Step => default(int);

		public int IsPickUp => default(int);

		public int CompleteValue => default(int);

		public int ProgressFlag => default(int);

		public MissionTransportType MissionTransportType => default(MissionTransportType);

		public int TransportValue => default(int);

		public GiftType EntityType => default(GiftType);

		public int EntityId => default(int);

		public int EntityQuantity => default(int);

		public int NeedCompleteMissionId => default(int);
	}
}
