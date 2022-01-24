using System;
using Gluon.Master;

namespace Gluon
{
	public class CharacterCustomPointController_NN : CharacterCustomPointController
	{
		public enum CommandType
		{
			None,
			EnableConsumeCpToUseSp,
			DisableConsumeCpToUseSp,
			OnConsumeCpToUseSp
		}

		private int lastCP;

		private int consumeCPVal;

		private bool hasCpCommand;

		protected override void Initialize(CharacterBase owner, AbilityDataElement[] elems)
		{
		}

		public override void AttachToUI()
		{
		}

		public override void SetCP(int index, int value)
		{
		}

		private void OnGaugeAnimComplete(int index)
		{
		}

		protected override void TriggerAbility(AbilityDataElement ade, int actionId = 0, int skillId = 0, int skillIndex = 0)
		{
		}

		private void ApplyUIEffect(Action onUIDone)
		{
		}

		private void OnCPMatched(AbilityDataElement ade, int actionId, int skillId, int skillIndex)
		{
		}

		public override IconType GetIconType()
		{
			return default(IconType);
		}

		private CharacterBase CheckCurrentCharaIsActiveInHierarchy()
		{
			return null;
		}

		public override bool OnCommand(int commandType, int param, CharacterBase aboutChara)
		{
			return default(bool);
		}

		public override bool CanConsumeCpToUseSkill(int skillIndex)
		{
			return default(bool);
		}

		public override bool IsEnableConsumeCpToUseSkill(int skillIndex)
		{
			return default(bool);
		}

		public override bool ClearCPOnContinue()
		{
			return default(bool);
		}
	}
}
