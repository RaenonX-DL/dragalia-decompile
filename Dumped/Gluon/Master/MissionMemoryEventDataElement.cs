using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MissionMemoryEventDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Text;

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

		[SerializeField]
		private int _EntityBuildupCount;

		[SerializeField]
		private int _EntityLimitBreakCount;

		[SerializeField]
		private int _EntityEquipableCount;

		[SerializeField]
		private int _EventId;

		[SerializeField]
		private int _CampaignId;

		[SerializeField]
		private int _NeedCompleteMissionId;

		[SerializeField]
		private int _NeedClearQuestId;

		[SerializeField]
		private int _BlankViewQuestStoryId;

		[SerializeField]
		private int _BlankViewQuestId;

		public int Id => default(int);

		public string Text => null;

		public int SortId => default(int);

		public int CompleteValue => default(int);

		public int ProgressFlag => default(int);

		public MissionTransportType MissionTransportType => default(MissionTransportType);

		public int TransportValue => default(int);

		public GiftType EntityType => default(GiftType);

		public int EntityId => default(int);

		public int EntityQuantity => default(int);

		public int EntityBuildupCount => default(int);

		public int EntityLimitBreakCount => default(int);

		public int EntityEquipableCount => default(int);

		public int EventId => default(int);

		public int CampaignId => default(int);

		public int NeedCompleteMissionId => default(int);

		public int NeedClearQuestId => default(int);

		public int BlankViewQuestStoryId => default(int);

		public int BlankViewQuestId => default(int);
	}
}
