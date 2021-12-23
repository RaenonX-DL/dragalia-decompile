using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class SkillDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private int _SkillType;

		[SerializeField]
		private int _IsDisplayableSkillDetail;

		[SerializeField]
		private string _SkillLv1IconName;

		[SerializeField]
		private string _SkillLv2IconName;

		[SerializeField]
		private string _SkillLv3IconName;

		[SerializeField]
		private string _SkillLv4IconName;

		[SerializeField]
		private string _Description1;

		[SerializeField]
		private string _Description2;

		[SerializeField]
		private string _Description3;

		[SerializeField]
		private string _Description4;

		[SerializeField]
		private int _Sp;

		[SerializeField]
		private int _SpLv2;

		[SerializeField]
		private int _SpLv3;

		[SerializeField]
		private int _SpLv4;

		[SerializeField]
		private int _SpEdit;

		[SerializeField]
		private int _SpLv2Edit;

		[SerializeField]
		private int _SpLv3Edit;

		[SerializeField]
		private int _SpLv4Edit;

		[SerializeField]
		private int _SpDragon;

		[SerializeField]
		private int _SpLv2Dragon;

		[SerializeField]
		private int _SpLv3Dragon;

		[SerializeField]
		private int _SpLv4Dragon;

		[SerializeField]
		private int _SpGaugeCount;

		[SerializeField]
		private int _SpRecoveryRule;

		[SerializeField]
		private float _AutoRecoverySpForDmode;

		[SerializeField]
		private float _AutoRecoverySpForDmodeWeaponSkill;

		[SerializeField]
		private int _RequiredBuffId;

		[SerializeField]
		private int _RequiredBuffCount;

		[SerializeField]
		private int _ActionId1;

		[SerializeField]
		private int _ActionId2;

		[SerializeField]
		private int _ActionId3;

		[SerializeField]
		private int _ActionId4;

		[SerializeField]
		private int _AdvancedSkillLv1;

		[SerializeField]
		private int _AdvancedActionId1;

		[SerializeField]
		private int _AdvancedSkillBaseId;

		[SerializeField]
		private int _BaseIdActionId;

		[SerializeField]
		private int _Ability1;

		[SerializeField]
		private int _Ability2;

		[SerializeField]
		private int _Ability3;

		[SerializeField]
		private int _Ability4;

		[SerializeField]
		private int _TransSkill;

		[SerializeField]
		private int _TransCondition;

		[SerializeField]
		private int _TransHitCount;

		[SerializeField]
		private int _ChainGroupId;

		[SerializeField]
		private int _MaxUseNum;

		[SerializeField]
		private int _ModeChange;

		[SerializeField]
		private int _Support;

		[SerializeField]
		private int _SupportSkillIndex;

		[SerializeField]
		private string _TransText;

		[SerializeField]
		private float _TransTime;

		[SerializeField]
		private int _TransBuff;

		[SerializeField]
		private int _OverChargeSkillId;

		[SerializeField]
		private int _MaxAdditionalCount;

		[SerializeField]
		private int _IsAffectedByTension;

		[SerializeField]
		private int _IsAffectedByTensionLv2;

		[SerializeField]
		private int _IsAffectedByTensionLv3;

		[SerializeField]
		private int _IsAffectedByTensionLv4;

		[SerializeField]
		private int _NotNeedTargetForFA;

		[SerializeField]
		private SkillVoiceType _VoiceType;

		[SerializeField]
		private SkillVoiceType _ShareVoiceType;

		[SerializeField]
		private string _OtherVoice;

		[SerializeField]
		private int _NoSkillVoiceSharedCharaBaseId;

		[SerializeField]
		private int _SkillButtonAnimType;

		[SerializeField]
		private ActionFocusPos _FocusType;

		[SerializeField]
		private float _ZoominTime;

		[SerializeField]
		private float _ZoominDistance;

		[SerializeField]
		private float _Zoom2Time;

		[SerializeField]
		private float _Zoom2Distance;

		[SerializeField]
		private float _AtPositionDistance;

		[SerializeField]
		private float _ZoomWaitTime;

		public int Id => default(int);

		public string Name => null;

		public int SkillType => default(int);

		public int IsDisplayableSkillDetail => default(int);

		public string SkillLv1IconName => null;

		public string SkillLv2IconName => null;

		public string SkillLv3IconName => null;

		public string SkillLv4IconName => null;

		public string Description1 => null;

		public string Description2 => null;

		public string Description3 => null;

		public string Description4 => null;

		public int Sp => default(int);

		public int SpLv2 => default(int);

		public int SpLv3 => default(int);

		public int SpLv4 => default(int);

		public int SpEdit => default(int);

		public int SpLv2Edit => default(int);

		public int SpLv3Edit => default(int);

		public int SpLv4Edit => default(int);

		public int SpDragon => default(int);

		public int SpLv2Dragon => default(int);

		public int SpLv3Dragon => default(int);

		public int SpLv4Dragon => default(int);

		public int SpGaugeCount => default(int);

		public int SpRecoveryRule => default(int);

		public float AutoRecoverySpForDmode => default(float);

		public float AutoRecoverySpForDmodeWeaponSkill => default(float);

		public int RequiredBuffId => default(int);

		public int RequiredBuffCount => default(int);

		public int ActionId1 => default(int);

		public int ActionId2 => default(int);

		public int ActionId3 => default(int);

		public int ActionId4 => default(int);

		public int AdvancedSkillLv1 => default(int);

		public int AdvancedActionId1 => default(int);

		public int AdvancedSkillBaseId => default(int);

		public int BaseIdActionId => default(int);

		public int Ability1 => default(int);

		public int Ability2 => default(int);

		public int Ability3 => default(int);

		public int Ability4 => default(int);

		public int TransSkill => default(int);

		public int TransCondition => default(int);

		public int TransHitCount => default(int);

		public int ChainGroupId => default(int);

		public int MaxUseNum => default(int);

		public int ModeChange => default(int);

		public int Support => default(int);

		public int SupportSkillIndex => default(int);

		public string TransText => null;

		public float TransTime => default(float);

		public int TransBuff => default(int);

		public int OverChargeSkillId => default(int);

		public int MaxAdditionalCount => default(int);

		public int IsAffectedByTension => default(int);

		public int IsAffectedByTensionLv2 => default(int);

		public int IsAffectedByTensionLv3 => default(int);

		public int IsAffectedByTensionLv4 => default(int);

		public int NotNeedTargetForFA => default(int);

		public SkillVoiceType VoiceType => default(SkillVoiceType);

		public SkillVoiceType ShareVoiceType => default(SkillVoiceType);

		public string OtherVoice => null;

		public int NoSkillVoiceSharedCharaBaseId => default(int);

		public int SkillButtonAnimType => default(int);

		public ActionFocusPos FocusType => default(ActionFocusPos);

		public float ZoominTime => default(float);

		public float ZoominDistance => default(float);

		public float Zoom2Time => default(float);

		public float Zoom2Distance => default(float);

		public float AtPositionDistance => default(float);

		public float ZoomWaitTime => default(float);
	}
}
