using Gluon.Master;

namespace Gluon
{
	public class ExAbility : AbilityBase
	{
		public void Initialize(CharacterBase original, CharacterBase current)
		{
		}

		public void Update(CharacterBase original, CharacterBase current)
		{
		}

		private void Apply(CharacterBase owner, ExAbilityDataElement ade, int idx)
		{
		}

		public static int GetType(ExAbilityDataElement ade, int idx)
		{
			return default(int);
		}

		public static AbilityTargetAction GetTargetAction(ExAbilityDataElement ade, int idx)
		{
			return default(AbilityTargetAction);
		}

		public static int GetVariousId(ExAbilityDataElement ade, int idx)
		{
			return default(int);
		}

		public static float GetValue(ExAbilityDataElement ade, int idx)
		{
			return default(float);
		}
	}
}
