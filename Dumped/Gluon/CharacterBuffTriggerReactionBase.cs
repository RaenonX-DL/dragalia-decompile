using System.Runtime.CompilerServices;

namespace Gluon
{
	public class CharacterBuffTriggerReactionBase
	{
		public int ActionId
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

		public int ActionConditionId
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

		public CharacterBuffTriggerReactionBase(int actionId, int actionConditionId)
		{
		}

		public virtual void Update()
		{
		}

		public virtual bool CanAcceptTrigger(ref CharacterAppendBuffTrigger trigger)
		{
			return default(bool);
		}

		public virtual void OnAppendBuff(ref CharacterAppendBuffTrigger trigger)
		{
		}

		public virtual bool CanAcceptTrigger(ref CharacterRemoveBuffTrigger trigger)
		{
			return default(bool);
		}

		public virtual void OnRemoveBuff(ref CharacterRemoveBuffTrigger trigger)
		{
		}
	}
}
