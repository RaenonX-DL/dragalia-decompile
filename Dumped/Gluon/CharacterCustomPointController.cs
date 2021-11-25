using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class CharacterCustomPointController
	{
		public enum AbilityTriggerState
		{
			Disabled,
			On,
			Off
		}

		public enum Type
		{
			None = 0,
			SZ = 10750403,
			RKS = 10350102,
			CRS = 10650304,
			IRA = 10950401,
			ZN = 10850402,
			BP = 10150404,
			SM = 10750104,
			SS = 10750404,
			SSR = 10950303,
			RKSH = 10950403,
			IRAX = 10950103,
			GTF = 10450104,
			NEV = 10350304
		}

		public enum IconType
		{
			None,
			SZ,
			RKS,
			IRA,
			ZN,
			BP,
			SM,
			CRS,
			SS,
			SSR,
			RKSH,
			GTF
		}

		public class RequestCPEventData
		{
			public int value;

			public bool isDirty;
		}

		public static readonly int gaugeIndexMax;

		protected ObscuredInt[] cp;

		public float[] coef;

		protected List<AbilityDataElement> abilityList;

		public Type type;

		private RequestCPEventData[] _requestCPEventList;

		private float _nextSendEventTimer;

		private static readonly float SendEventInterval;

		public virtual int minCP => default(int);

		public virtual int maxCP => default(int);

		public CharacterBase owner
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

		public CollisionHitAttribute hitAttributeSource
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

		public static CharacterCustomPointController Create(CharacterBase owner, List<ConditionallyAbility> conditionalAbilities, int charaId)
		{
			return null;
		}

		private static CharacterCustomPointController Create(CharacterBase owner, Type type, AbilityDataElement[] elems)
		{
			return null;
		}

		public virtual void AttachToUI()
		{
		}

		public virtual int GetCP(int index)
		{
			return default(int);
		}

		protected virtual void Initialize(CharacterBase owner, AbilityDataElement[] elems)
		{
		}

		protected virtual void InitializeWithLength(int length)
		{
		}

		public virtual void ClearValues()
		{
		}

		public virtual void Update()
		{
		}

		public void SetModifyCPSource(CollisionHitAttribute attr)
		{
		}

		public virtual void SetCP(int index, int value)
		{
		}

		public virtual void AddCP(int index, int value)
		{
		}

		protected virtual AbilityCondition GetUseConditionType(AbilityDataElement ade)
		{
			return default(AbilityCondition);
		}

		protected virtual void TriggerAbility(AbilityDataElement ade, int actionId = 0, int skillId = 0, int skillIndex = 0)
		{
		}

		public virtual void OnSkill(int actionId, int skillId, int skillIndex)
		{
		}

		public virtual void OnContinue()
		{
		}

		public virtual IconType GetIconType()
		{
			return default(IconType);
		}

		public virtual bool ClearCPOnContinue()
		{
			return default(bool);
		}

		public virtual bool ClearCPOnReborn()
		{
			return default(bool);
		}

		public void RequestSendCPEvent(int index, int value)
		{
		}

		protected void UpdateSendRequest(CharacterBase owner)
		{
		}

		public void SendCPEventImmediately(CharacterBase target, int index, int value)
		{
		}

		public virtual void OnReceiveCharacterCustomPointEvent(CharacterCustomPointEvent recvEvent)
		{
		}

		public virtual int GetChargeLevel()
		{
			return default(int);
		}

		public virtual bool OnCommand(int commandType, int param, CharacterBase aboutChara)
		{
			return default(bool);
		}
	}
}
