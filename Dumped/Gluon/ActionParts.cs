using System.Runtime.CompilerServices;
using Gluon.ActionData;

namespace Gluon
{
	public abstract class ActionParts : ActionBase
	{
		public abstract class PartsData
		{
		}

		protected ActionContainer container;

		private float _originalStartTime;

		private float _originalDuration;

		protected Gluon.ActionData.ActionParts.PartsData.ConditionData conditionData;

		private int loopCount;

		protected bool IsIgnoreFinishConditionOnUpdate;

		protected int actionId => default(int);

		protected int productId => default(int);

		protected int chargeLv => default(int);

		public float duration
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public float endTime => default(float);

		public float tempoScale
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

		public int activateId
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

		protected Gluon.ActionData.ActionParts.PartsData.LoopData loopData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected bool isDoneGuarantee
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

		public ActionParts(Gluon.ActionData.ActionParts resource)
		{
		}

		public virtual int[] GetActionIdsForLoad()
		{
			return null;
		}

		public void RegisterParentActionContainer(ActionContainer container)
		{
		}

		public virtual void OnPostCreated(CharacterBase chara)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		public override bool Update(float delta)
		{
			return default(bool);
		}

		protected bool CheckHitAttributeLabel(ref string label, bool useSameComponent, int overwriteSkillId = 0)
		{
			return default(bool);
		}

		protected override bool IsMatchExecuteCondition()
		{
			return default(bool);
		}

		protected override bool IsCheckExecuteConditionEnabledOnStart()
		{
			return default(bool);
		}

		protected override bool ContinueCheckExecuteCondition(float t)
		{
			return default(bool);
		}

		public bool IsSyncWithStartParam()
		{
			return default(bool);
		}

		public override bool IsConditionCheckResultFailed()
		{
			return default(bool);
		}

		protected virtual bool CanGuarantee(bool flag)
		{
			return default(bool);
		}

		public static bool CheckHitAttributeLabel(ref string label, CharacterBase owner, int actionId, int skillId, int chargeLv, bool useSameComponent)
		{
			return default(bool);
		}

		public static bool IsMatchHitAttirbuteShiftCondition(CharacterBase owner)
		{
			return default(bool);
		}

		public static ElementalType GetShareCharaElement(CharacterBase owner, int skillId)
		{
			return default(ElementalType);
		}

		public static int GetShareCharaBaseId(HumanCharacter human, int skillId)
		{
			return default(int);
		}

		public static bool IsShareSkill(CharacterBase owner, int skillId)
		{
			return default(bool);
		}
	}
}
