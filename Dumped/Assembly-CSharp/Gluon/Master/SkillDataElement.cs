/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class SkillDataElement : IMasterElement
	{
		// Fields
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
		private string _TransText;
		[SerializeField]
		private float _TransTime;
		[SerializeField]
		private int _TransBuff;
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
		private SkillVoiceType _VoiceType;
		[SerializeField]
		private SkillVoiceType _ShareVoiceType;
		[SerializeField]
		private string _OtherVoice;
		[SerializeField]
		private int _NoSkillVoiceSharedCharaBaseId;
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
	
		// Properties
		public int Id { get; }
		public string Name { get; }
		public int SkillType { get; }
		public int IsDisplayableSkillDetail { get; }
		public string SkillLv1IconName { get; }
		public string SkillLv2IconName { get; }
		public string SkillLv3IconName { get; }
		public string SkillLv4IconName { get; }
		public string Description1 { get; }
		public string Description2 { get; }
		public string Description3 { get; }
		public string Description4 { get; }
		public int Sp { get; }
		public int SpLv2 { get; }
		public int SpLv3 { get; }
		public int SpLv4 { get; }
		public int SpEdit { get; }
		public int SpLv2Edit { get; }
		public int SpLv3Edit { get; }
		public int SpLv4Edit { get; }
		public int SpDragon { get; }
		public int SpLv2Dragon { get; }
		public int SpLv3Dragon { get; }
		public int SpLv4Dragon { get; }
		public int SpGaugeCount { get; }
		public int SpRecoveryRule { get; }
		public int RequiredBuffId { get; }
		public int RequiredBuffCount { get; }
		public int ActionId1 { get; }
		public int ActionId2 { get; }
		public int ActionId3 { get; }
		public int ActionId4 { get; }
		public int AdvancedSkillLv1 { get; }
		public int AdvancedActionId1 { get; }
		public int AdvancedSkillBaseId { get; }
		public int BaseIdActionId { get; }
		public int Ability1 { get; }
		public int Ability2 { get; }
		public int Ability3 { get; }
		public int Ability4 { get; }
		public int TransSkill { get; }
		public int TransCondition { get; }
		public int TransHitCount { get; }
		public int ChainGroupId { get; }
		public int MaxUseNum { get; }
		public int ModeChange { get; }
		public int Support { get; }
		public string TransText { get; }
		public float TransTime { get; }
		public int TransBuff { get; }
		public int MaxAdditionalCount { get; }
		public int IsAffectedByTension { get; }
		public int IsAffectedByTensionLv2 { get; }
		public int IsAffectedByTensionLv3 { get; }
		public int IsAffectedByTensionLv4 { get; }
		public SkillVoiceType VoiceType { get; }
		public SkillVoiceType ShareVoiceType { get; }
		public string OtherVoice { get; }
		public int NoSkillVoiceSharedCharaBaseId { get; }
		public ActionFocusPos FocusType { get; }
		public float ZoominTime { get; }
		public float ZoominDistance { get; }
		public float Zoom2Time { get; }
		public float Zoom2Distance { get; }
		public float AtPositionDistance { get; }
		public float ZoomWaitTime { get; }
	
		// Constructors
		public SkillDataElement();
	}
}
