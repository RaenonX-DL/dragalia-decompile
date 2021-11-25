using Gluon.Master;

namespace Gluon
{
	public class CharacterCustomPointController_IRAX : CharacterCustomPointController
	{
		protected override void Initialize(CharacterBase owner, AbilityDataElement[] elems)
		{
		}

		public override void AttachToUI()
		{
		}

		public override void SetCP(int index, int value)
		{
		}

		private void OnGaugeAnimComplete(int index, int prevCP, int currCP)
		{
		}

		public override void OnSkill(int actionId, int skillId, int skillIndex)
		{
		}

		private void OnCPMatched(AbilityDataElement ade, int actionId, int skillId, int skillIndex)
		{
		}

		public override void OnContinue()
		{
		}

		public override IconType GetIconType()
		{
			return default(IconType);
		}
	}
}
