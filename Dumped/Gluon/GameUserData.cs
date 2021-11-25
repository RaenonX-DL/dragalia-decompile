using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class GameUserData
	{
		private bool _isPause;

		private List<GameExAbilityData> partyExAbilityDataList;

		private DragonGaugeMultiPlayService _dragonGaugeMultiPlayService;

		public bool isPause
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int dp
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int maxDp
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int consumeDp
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int acquiredDpForAbility
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isActivateAcquiredDpAbility
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isEquippedDragon
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float dragonTransformRecastSec
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float eventPassiveDpChargeRate
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float requestCapRate
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float questStartChargeRate
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int supportSkillMaxNum
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int supportSkillRemainNum
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float supportSkillRecastSec
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int chainNumBestRecord
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Initialize()
		{
		}

		public void Update()
		{
		}

		private void CheckActivateAbilityForAcquiredDp(int value)
		{
		}

		public void OnPartySwitch()
		{
		}

		public void SetDp(int value, bool immediate = true, bool withEffectAndSE = true)
		{
		}

		public void RecoveryDp(int value, float rate, bool immediate = true, bool withEffectAndSE = true)
		{
		}

		public void ConsumeDp(HumanCharacter human)
		{
		}

		public void ConsumeDpByRate(float rate)
		{
		}

		public void RecoverDpByRate(float rate)
		{
		}

		public void AddQuestStartChargeRate(float rate)
		{
		}

		public void ApplyQuestStartChargeRate()
		{
		}

		public float GetDpRate()
		{
			return default(float);
		}

		public bool IsDpFull()
		{
			return default(bool);
		}

		public bool HasDpForTransform(float rate)
		{
			return default(bool);
		}

		public bool IsEnableTransform(float rate)
		{
			return default(bool);
		}

		public void SetupExAbility(CharacterPartySwitch partySwitch)
		{
		}

		public void ApplyEventPassive()
		{
		}

		private void SetupParameter(CharacterSelector selector)
		{
		}

		public void Continue()
		{
		}

		public List<ExAbilityDataElement> GetExAbility1List(int actorIndex, int partySwitchIndex)
		{
			return null;
		}

		public List<AbilityDataElement> GetExAbility2List(int actorIndex, int partySwitchIndex)
		{
			return null;
		}

		public void SetTransformRecastTime()
		{
		}

		public void InitializeSupportSkill(bool isFriend)
		{
		}

		public void ResetSupportSkill()
		{
		}

		public void UseSupportSkill()
		{
		}

		public void SetSupporSkillRecastTime()
		{
		}

		public void OnReceiveEvent(DragonGauge recvEvent)
		{
		}
	}
}
