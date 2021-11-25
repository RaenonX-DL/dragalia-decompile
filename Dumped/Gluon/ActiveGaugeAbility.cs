using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class ActiveGaugeAbility
	{
		public enum ActiveGaugeType
		{
			None,
			Ranzal
		}

		private class Param
		{
			protected const int PARAM_ELEMENT_NUM = 2;

			public int curMaxGaugeNum;

			public int saveMaxGaugeNum;

			public AbilityDataElement ade
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				protected set
				{
				}
			}

			public int adeIdx
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				protected set
				{
				}
			}

			public AbilityTargetAction targetAction
			{
				[CompilerGenerated]
				get
				{
					return default(AbilityTargetAction);
				}
				[CompilerGenerated]
				protected set
				{
				}
			}

			public int targetSkillLv
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				protected set
				{
				}
			}

			public int[] gaugeValueList
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				protected set
				{
				}
			}

			public int[] accumulateEnhanceList
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				protected set
				{
				}
			}

			public int[] consumeEnhanceList
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				protected set
				{
				}
			}

			public virtual ActiveGaugeType type => default(ActiveGaugeType);

			public virtual bool Initialize(AbilityDataElement ade, int idx)
			{
				return default(bool);
			}

			public void AddGaugeValue(int idx, int val)
			{
			}

			public void SetGaugeValue(int idx, int val)
			{
			}

			public int GetGaugeValue(int idx)
			{
				return default(int);
			}

			public int GetMaxGaugeNum()
			{
				return default(int);
			}

			public virtual bool IsAllGaugeMax()
			{
				return default(bool);
			}

			public void ResetGaugeValue()
			{
			}

			public float GetAccumulateEnhanceRate(int idx)
			{
				return default(float);
			}

			public float GetConsumeEnhanceRate(int idx)
			{
				return default(float);
			}

			public void ClearGaugeValue()
			{
			}
		}

		private class ParamRanzal : Param
		{
			public enum GaugeType
			{
				Normal,
				Burst
			}

			private const int GAUGE_NUM = 2;

			public override ActiveGaugeType type => default(ActiveGaugeType);

			public override bool Initialize(AbilityDataElement ade, int idx)
			{
				return default(bool);
			}

			public override bool IsAllGaugeMax()
			{
				return default(bool);
			}
		}

		private const int EFFECT_TRIGGER_OFFSET_1ST = 7;

		private const int EFFECT_TRIGGER_OFFSET_2ND = 12;

		private HumanCharacter _owner;

		private Param _param;

		private bool _isDirty;

		public AbilityGaugeMultiPlayService MultiPlayService
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isActive => default(bool);

		public void Initialize(CharacterBase original, CharacterBase current)
		{
		}

		public void Setup(CharacterBase owner, AbilityDataElement ade, int idx)
		{
		}

		public void OnHit(CollisionHitAttribute attr, PlayerActionElement action)
		{
		}

		public bool Update()
		{
			return default(bool);
		}

		private bool ApplyAccumulateEnhance(bool force = false)
		{
			return default(bool);
		}

		private void ApplyRanzal(int idx)
		{
		}

		public void ResetGaugeValue(int actionId)
		{
		}

		public float GetConsumeEnhanceRate(CollisionHitAttribute attr)
		{
			return default(float);
		}

		public bool IsConsumeEnhanceTargetAction(int actionId)
		{
			return default(bool);
		}

		public void RestoreEffect()
		{
		}

		public int GetConsumeEnhanceEffectIdx()
		{
			return default(int);
		}

		public int[] GetGaugeValueList()
		{
			return null;
		}

		public void SetGaugeValueList(int[] gaugeValueList)
		{
		}

		public void ClearGaugeValue()
		{
		}
	}
}
