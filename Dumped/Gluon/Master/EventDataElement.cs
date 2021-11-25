using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EventDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private EventKindType _EventKindType;

		[SerializeField]
		private int _BaseEventId;

		[SerializeField]
		private int _EventViewType;

		[SerializeField]
		private int _IsMemoryEvent;

		[SerializeField]
		private int _IsPickupMemoryEvent;

		[SerializeField]
		private string _RewardMasterName;

		[SerializeField]
		private string _EventRewardText;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private int _ReleaseQuestStoryId;

		[SerializeField]
		private string _ReleaseQuestStoryText;

		[SerializeField]
		private int _PrologueId;

		[SerializeField]
		private int _EpilogueId;

		[SerializeField]
		private int _PrologueQuestId;

		[SerializeField]
		private string _AnnounceVoice1;

		[SerializeField]
		private string _AnnounceVoice2;

		[SerializeField]
		private GiftType _ViewEntityType1;

		[SerializeField]
		private int _ViewEntityId1;

		[SerializeField]
		private GiftType _ViewEntityType2;

		[SerializeField]
		private int _ViewEntityId2;

		[SerializeField]
		private GiftType _ViewEntityType3;

		[SerializeField]
		private int _ViewEntityId3;

		[SerializeField]
		private GiftType _ViewEntityType4;

		[SerializeField]
		private int _ViewEntityId4;

		[SerializeField]
		private GiftType _ViewEntityType5;

		[SerializeField]
		private int _ViewEntityId5;

		[SerializeField]
		private int _AnnouncePageCount;

		[SerializeField]
		private int _TutorialPageCount;

		[SerializeField]
		private string _EventTopMusic;

		[SerializeField]
		private int _EventTopDataId;

		[SerializeField]
		private int _EventCharaId;

		[SerializeField]
		private int _IsNotAddFriendshipPoint;

		[SerializeField]
		private int _GuestJoinStoryId;

		[SerializeField]
		private int _EventCharaAbilityId1;

		[SerializeField]
		private int _EventCharaAbilityId2;

		[SerializeField]
		private int _EventFortId;

		[SerializeField]
		private int _FortCompleteLevel;

		[SerializeField]
		private int _IsUseEventPassive;

		[SerializeField]
		private int _IsUseEventStory;

		[SerializeField]
		private int _IsPreEntry;

		[SerializeField]
		private int _UseEventCharaAbilityList;

		[SerializeField]
		private int _UseTotalDamageReward;

		[SerializeField]
		private int _InformationId;

		[SerializeField]
		private int _SortJd;

		[SerializeField]
		private string _ViewAnnounceDate;

		[SerializeField]
		private string _StartDate;

		[SerializeField]
		private string _EndDate;

		[SerializeField]
		private string _ViewCloseDate;

		[SerializeField]
		private int _IsViewCloseState;

		[SerializeField]
		private int _NextEventAnnounceStoryId;

		[SerializeField]
		private string _ViewNewDate;

		[SerializeField]
		private string _BackgroundImage;

		[SerializeField]
		private int _ChallengeQuestDailyRewardCount;

		public int Id => default(int);

		public EventKindType EventKindType => default(EventKindType);

		public int BaseEventId => default(int);

		public int EventViewType => default(int);

		public int IsMemoryEvent => default(int);

		public int IsPickupMemoryEvent => default(int);

		public string RewardMasterName => null;

		public string EventRewardText => null;

		public string Name => null;

		public int ReleaseQuestStoryId => default(int);

		public string ReleaseQuestStoryText => null;

		public int PrologueId => default(int);

		public int EpilogueId => default(int);

		public int PrologueQuestId => default(int);

		public string AnnounceVoice1 => null;

		public string AnnounceVoice2 => null;

		public GiftType ViewEntityType1 => default(GiftType);

		public int ViewEntityId1 => default(int);

		public GiftType ViewEntityType2 => default(GiftType);

		public int ViewEntityId2 => default(int);

		public GiftType ViewEntityType3 => default(GiftType);

		public int ViewEntityId3 => default(int);

		public GiftType ViewEntityType4 => default(GiftType);

		public int ViewEntityId4 => default(int);

		public GiftType ViewEntityType5 => default(GiftType);

		public int ViewEntityId5 => default(int);

		public int AnnouncePageCount => default(int);

		public int TutorialPageCount => default(int);

		public string EventTopMusic => null;

		public int EventTopDataId => default(int);

		public int EventCharaId => default(int);

		public int IsNotAddFriendshipPoint => default(int);

		public int GuestJoinStoryId => default(int);

		public int EventCharaAbilityId1 => default(int);

		public int EventCharaAbilityId2 => default(int);

		public int EventFortId => default(int);

		public int FortCompleteLevel => default(int);

		public int IsUseEventPassive => default(int);

		public int IsUseEventStory => default(int);

		public int IsPreEntry => default(int);

		public int UseEventCharaAbilityList => default(int);

		public int UseTotalDamageReward => default(int);

		public int InformationId => default(int);

		public int SortJd => default(int);

		public string ViewAnnounceDate => null;

		public string StartDate => null;

		public string EndDate => null;

		public string ViewCloseDate => null;

		public int IsViewCloseState => default(int);

		public int NextEventAnnounceStoryId => default(int);

		public string ViewNewDate => null;

		public string BackgroundImage => null;

		public int ChallengeQuestDailyRewardCount => default(int);
	}
}
