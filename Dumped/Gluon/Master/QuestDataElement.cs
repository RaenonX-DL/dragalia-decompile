using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Gid;

		[SerializeField]
		private QuestGroupType _GroupType;

		[SerializeField]
		private string _SectionName;

		[SerializeField]
		private string _QuestViewName;

		[SerializeField]
		private string _QuestDifficultyName;

		[SerializeField]
		private QuestPlayModeType _QuestPlayModeType;

		[SerializeField]
		private int _SearchClearPartyTabType;

		[SerializeField]
		private Gluon.ElementalType _Elemental;

		[SerializeField]
		private Gluon.ElementalType _Elemental2;

		[SerializeField]
		private Gluon.ElementalType _LimitedElementalType;

		[SerializeField]
		private Gluon.ElementalType _LimitedElementalType2;

		[SerializeField]
		private int _LimitedWeaponTypePatternId;

		[SerializeField]
		private int _Difficulty;

		[SerializeField]
		private int _PayStaminaSingle;

		[SerializeField]
		private int _CampaignStaminaSingle;

		[SerializeField]
		private int _PayStaminaMulti;

		[SerializeField]
		private int _CampaignStaminaMulti;

		[SerializeField]
		private int _IsPayForceStaminaSingle;

		[SerializeField]
		private int _SkipTicketCount;

		[SerializeField]
		private Gluon.QuestClearType _ClearTermsType;

		[SerializeField]
		private float _ClearTermsTimeElapsed;

		[SerializeField]
		private Gluon.QuestFailedType _FailedTermsType;

		[SerializeField]
		private float _FailedTermsTimeElapsed;

		[SerializeField]
		private int _GuestAppearType;

		[SerializeField]
		private int _GuestUnitId;

		[SerializeField]
		private int _QuestOverwriteId;

		[SerializeField]
		private int _QuestEffectiveAbilityId;

		[SerializeField]
		private int _QuestOrderPartyGroupId;

		[SerializeField]
		private DungeonType _DungeonType;

		[SerializeField]
		private int _QuestOverrideViewId;

		[SerializeField]
		private int _WaveCount;

		[SerializeField]
		private int _VariationType;

		[SerializeField]
		private int _DecorationType;

		[SerializeField]
		private float _EnemyHpCollection;

		[SerializeField]
		private float _EnemyAttackCollection;

		[SerializeField]
		private float _OverwhelmCollection;

		[SerializeField]
		private string _Scene01;

		[SerializeField]
		private string _AreaName01;

		[SerializeField]
		private string _Scene02;

		[SerializeField]
		private string _AreaName02;

		[SerializeField]
		private string _Scene03;

		[SerializeField]
		private string _AreaName03;

		[SerializeField]
		private string _Scene04;

		[SerializeField]
		private string _AreaName04;

		[SerializeField]
		private string _Scene05;

		[SerializeField]
		private string _AreaName05;

		[SerializeField]
		private string _Scene06;

		[SerializeField]
		private string _AreaName06;

		[SerializeField]
		private string _BossMultiSceneName;

		[SerializeField]
		private int _IsDisplayStorySkip;

		[SerializeField]
		private int _Area01Start;

		[SerializeField]
		private int _Area02Start;

		[SerializeField]
		private int _Area03Start;

		[SerializeField]
		private int _Area04Start;

		[SerializeField]
		private int _Area05Start;

		[SerializeField]
		private int _Area06Start;

		[SerializeField]
		private int _FinishAreaEndStory;

		[SerializeField]
		private string _CommonIngameCuttId;

		[SerializeField]
		private int _EnemyPatternNumber;

		[SerializeField]
		private int _RandomAreaId;

		[SerializeField]
		private QuestResetIntervalType _ResetType;

		[SerializeField]
		private int _PlayCnt;

		[SerializeField]
		private int _LeaveAloneLimitTime;

		[SerializeField]
		private int _RebornLimit;

		[SerializeField]
		private int _ContinueLimit;

		[SerializeField]
		private int _DifficultyLimit;

		[SerializeField]
		private int _EntryConditionId;

		[SerializeField]
		private QuestEntryType _EntryType;

		[SerializeField]
		private int _EntryValue1;

		[SerializeField]
		private int _EntryValue2;

		[SerializeField]
		private int _AutoPlayType;

		[SerializeField]
		private int _RepeatState;

		[SerializeField]
		private int _PayEntityTargetType;

		[SerializeField]
		private GiftType _PayEntityType;

		[SerializeField]
		private int _PayEntityId;

		[SerializeField]
		private int _PayEntityQuantity;

		[SerializeField]
		private int _IsLockView;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		[SerializeField]
		private string _ViewStartDate2;

		[SerializeField]
		private string _ViewEndDate2;

		[SerializeField]
		private int _ScheduleGroupId;

		[SerializeField]
		private GiftType _HoldEntityType;

		[SerializeField]
		private int _HoldEntityId;

		[SerializeField]
		private int _HoldEntityQuantity;

		[SerializeField]
		private QuestConstraintType _ConstraintType;

		[SerializeField]
		private int _IsSumUpTotalDamage;

		[SerializeField]
		private QuestGroupIntervalType _QuestGroupIntervalType;

		[SerializeField]
		private string _ThumbnailImage;

		[SerializeField]
		private string _ArmoryBackImage;

		[SerializeField]
		private string _DetailTextImage;

		public int Id => default(int);

		public int Gid => default(int);

		public QuestGroupType GroupType => default(QuestGroupType);

		public string SectionName => null;

		public string QuestViewName => null;

		public string QuestDifficultyName => null;

		public QuestPlayModeType QuestPlayModeType => default(QuestPlayModeType);

		public int SearchClearPartyTabType => default(int);

		public Gluon.ElementalType Elemental => default(Gluon.ElementalType);

		public Gluon.ElementalType Elemental2 => default(Gluon.ElementalType);

		public Gluon.ElementalType LimitedElementalType => default(Gluon.ElementalType);

		public Gluon.ElementalType LimitedElementalType2 => default(Gluon.ElementalType);

		public int LimitedWeaponTypePatternId => default(int);

		public int Difficulty => default(int);

		public int PayStaminaSingle => default(int);

		public int CampaignStaminaSingle => default(int);

		public int PayStaminaMulti => default(int);

		public int CampaignStaminaMulti => default(int);

		public int IsPayForceStaminaSingle => default(int);

		public int SkipTicketCount => default(int);

		public Gluon.QuestClearType ClearTermsType => default(Gluon.QuestClearType);

		public float ClearTermsTimeElapsed => default(float);

		public Gluon.QuestFailedType FailedTermsType => default(Gluon.QuestFailedType);

		public float FailedTermsTimeElapsed => default(float);

		public int GuestAppearType => default(int);

		public int GuestUnitId => default(int);

		public int QuestOverwriteId => default(int);

		public int QuestEffectiveAbilityId => default(int);

		public int QuestOrderPartyGroupId => default(int);

		public DungeonType DungeonType => default(DungeonType);

		public int QuestOverrideViewId => default(int);

		public int WaveCount => default(int);

		public int VariationType => default(int);

		public int DecorationType => default(int);

		public float EnemyHpCollection => default(float);

		public float EnemyAttackCollection => default(float);

		public float OverwhelmCollection => default(float);

		public string Scene01 => null;

		public string AreaName01 => null;

		public string Scene02 => null;

		public string AreaName02 => null;

		public string Scene03 => null;

		public string AreaName03 => null;

		public string Scene04 => null;

		public string AreaName04 => null;

		public string Scene05 => null;

		public string AreaName05 => null;

		public string Scene06 => null;

		public string AreaName06 => null;

		public string BossMultiSceneName => null;

		public int IsDisplayStorySkip => default(int);

		public int Area01Start => default(int);

		public int Area02Start => default(int);

		public int Area03Start => default(int);

		public int Area04Start => default(int);

		public int Area05Start => default(int);

		public int Area06Start => default(int);

		public int FinishAreaEndStory => default(int);

		public string CommonIngameCuttId => null;

		public int EnemyPatternNumber => default(int);

		public int RandomAreaId => default(int);

		public QuestResetIntervalType ResetType => default(QuestResetIntervalType);

		public int PlayCnt => default(int);

		public int LeaveAloneLimitTime => default(int);

		public int RebornLimit => default(int);

		public int ContinueLimit => default(int);

		public int DifficultyLimit => default(int);

		public int EntryConditionId => default(int);

		public QuestEntryType EntryType => default(QuestEntryType);

		public int EntryValue1 => default(int);

		public int EntryValue2 => default(int);

		public int AutoPlayType => default(int);

		public int RepeatState => default(int);

		public int PayEntityTargetType => default(int);

		public GiftType PayEntityType => default(GiftType);

		public int PayEntityId => default(int);

		public int PayEntityQuantity => default(int);

		public int IsLockView => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;

		public string ViewStartDate2 => null;

		public string ViewEndDate2 => null;

		public int ScheduleGroupId => default(int);

		public GiftType HoldEntityType => default(GiftType);

		public int HoldEntityId => default(int);

		public int HoldEntityQuantity => default(int);

		public QuestConstraintType ConstraintType => default(QuestConstraintType);

		public int IsSumUpTotalDamage => default(int);

		public QuestGroupIntervalType QuestGroupIntervalType => default(QuestGroupIntervalType);

		public string ThumbnailImage => null;

		public string ArmoryBackImage => null;

		public string DetailTextImage => null;
	}
}
