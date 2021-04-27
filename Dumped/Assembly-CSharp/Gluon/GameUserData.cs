/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GameUserData
	{
		// Fields
		private bool _isPause;
		[CompilerGenerated]
		private int _dp_k__BackingField;
		[CompilerGenerated]
		private int _maxDp_k__BackingField;
		[CompilerGenerated]
		private int _consumeDp_k__BackingField;
		[CompilerGenerated]
		private int _acquiredDpForAbility_k__BackingField;
		[CompilerGenerated]
		private bool _isActivateAcquiredDpAbility_k__BackingField;
		[CompilerGenerated]
		private bool _isEquippedDragon_k__BackingField;
		[CompilerGenerated]
		private float _dragonTransformRecastSec_k__BackingField;
		[CompilerGenerated]
		private float _eventPassiveDpChargeRate_k__BackingField;
		[CompilerGenerated]
		private int _supportSkillMaxNum_k__BackingField;
		[CompilerGenerated]
		private int _supportSkillRemainNum_k__BackingField;
		[CompilerGenerated]
		private float _supportSkillRecastSec_k__BackingField;
		[CompilerGenerated]
		private int _chainNumBestRecord_k__BackingField;
		private List<GameExAbilityData> partyExAbilityDataList;
		private DragonGaugeMultiPlayService _dragonGaugeMultiPlayService;
	
		// Properties
		public bool isPause { get; set; }
		public int dp { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int maxDp { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int consumeDp { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int acquiredDpForAbility { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isActivateAcquiredDpAbility { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isEquippedDragon { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float dragonTransformRecastSec { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float eventPassiveDpChargeRate { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int supportSkillMaxNum { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int supportSkillRemainNum { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float supportSkillRecastSec { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int chainNumBestRecord { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public GameUserData();
	
		// Methods
		public void Initialize();
		public void Update();
		private void CheckActivateAbilityForAcquiredDp(int value);
		public void OnPartySwitch();
		public void SetDp(int value, bool immediate = true, bool withEffectAndSE = true);
		public void RecoveryDp(int value, bool immediate = true, bool withEffectAndSE = true);
		public void ConsumeDp(HumanCharacter human);
		public void ConsumeDpByRate(float rate);
		public float GetDpRate();
		public bool IsDpFull();
		private bool HasDpForTransform();
		public bool IsEnableTransform();
		public void SetupExAbility(CharacterPartySwitch partySwitch);
		public void ApplyEventPassive();
		private void SetupParameter(CharacterSelector selector);
		public void Continue();
		public List<ExAbilityDataElement> GetExAbility1List(int actorIndex, int partySwitchIndex);
		public List<AbilityDataElement> GetExAbility2List(int actorIndex, int partySwitchIndex);
		public void SetTransformRecastTime();
		public void InitializeSupportSkill(bool isFriend);
		public void ResetSupportSkill();
		public void UseSupportSkill();
		public void SetSupporSkillRecastTime();
		public void OnReceiveEvent(DragonGauge recvEvent);
	}
}
