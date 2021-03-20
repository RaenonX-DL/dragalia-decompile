/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class QuestDataElement : IMasterElement
	{
		// Fields
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
		private ElementalType _Elemental;
		[SerializeField]
		private ElementalType _LimitedElementalType;
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
		private QuestClearType _ClearTermsType;
		[SerializeField]
		private QuestFailedType _FailedTermsType;
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
		private QuestGroupIntervalType _QuestGroupIntervalType;
		[SerializeField]
		private string _ThumbnailImage;
		[SerializeField]
		private string _ArmoryBackImage;
		[SerializeField]
		private string _DetailTextImage;
	
		// Properties
		public int Id { get; }
		public int Gid { get; }
		public QuestGroupType GroupType { get; }
		public string SectionName { get; }
		public string QuestViewName { get; }
		public string QuestDifficultyName { get; }
		public QuestPlayModeType QuestPlayModeType { get; }
		public ElementalType Elemental { get; }
		public ElementalType LimitedElementalType { get; }
		public int Difficulty { get; }
		public int PayStaminaSingle { get; }
		public int CampaignStaminaSingle { get; }
		public int PayStaminaMulti { get; }
		public int CampaignStaminaMulti { get; }
		public int IsPayForceStaminaSingle { get; }
		public int SkipTicketCount { get; }
		public QuestClearType ClearTermsType { get; }
		public QuestFailedType FailedTermsType { get; }
		public float FailedTermsTimeElapsed { get; }
		public int GuestAppearType { get; }
		public int GuestUnitId { get; }
		public int QuestOverwriteId { get; }
		public int QuestEffectiveAbilityId { get; }
		public int QuestOrderPartyGroupId { get; }
		public DungeonType DungeonType { get; }
		public int WaveCount { get; }
		public int VariationType { get; }
		public int DecorationType { get; }
		public float EnemyHpCollection { get; }
		public float EnemyAttackCollection { get; }
		public float OverwhelmCollection { get; }
		public string Scene01 { get; }
		public string AreaName01 { get; }
		public string Scene02 { get; }
		public string AreaName02 { get; }
		public string Scene03 { get; }
		public string AreaName03 { get; }
		public string Scene04 { get; }
		public string AreaName04 { get; }
		public string Scene05 { get; }
		public string AreaName05 { get; }
		public string Scene06 { get; }
		public string AreaName06 { get; }
		public string BossMultiSceneName { get; }
		public int IsDisplayStorySkip { get; }
		public int Area01Start { get; }
		public int Area02Start { get; }
		public int Area03Start { get; }
		public int Area04Start { get; }
		public int Area05Start { get; }
		public int Area06Start { get; }
		public int FinishAreaEndStory { get; }
		public string CommonIngameCuttId { get; }
		public int EnemyPatternNumber { get; }
		public int RandomAreaId { get; }
		public QuestResetIntervalType ResetType { get; }
		public int PlayCnt { get; }
		public int LeaveAloneLimitTime { get; }
		public int RebornLimit { get; }
		public int ContinueLimit { get; }
		public int DifficultyLimit { get; }
		public int EntryConditionId { get; }
		public QuestEntryType EntryType { get; }
		public int EntryValue1 { get; }
		public int EntryValue2 { get; }
		public int AutoPlayType { get; }
		public int RepeatState { get; }
		public int PayEntityTargetType { get; }
		public GiftType PayEntityType { get; }
		public int PayEntityId { get; }
		public int PayEntityQuantity { get; }
		public int IsLockView { get; }
		public string ViewStartDate { get; }
		public string ViewEndDate { get; }
		public string ViewStartDate2 { get; }
		public string ViewEndDate2 { get; }
		public int ScheduleGroupId { get; }
		public GiftType HoldEntityType { get; }
		public int HoldEntityId { get; }
		public int HoldEntityQuantity { get; }
		public QuestConstraintType ConstraintType { get; }
		public QuestGroupIntervalType QuestGroupIntervalType { get; }
		public string ThumbnailImage { get; }
		public string ArmoryBackImage { get; }
		public string DetailTextImage { get; }
	
		// Constructors
		public QuestDataElement();
	}
}
