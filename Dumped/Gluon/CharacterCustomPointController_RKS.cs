using Gluon.Master;

namespace Gluon
{
	public class CharacterCustomPointController_RKS : CharacterCustomPointController
	{
		protected override void Initialize(CharacterBase owner, AbilityDataElement[] elems)
		{
		}

		public override void SetCP(int index, int value)
		{
		}

		private void OnGaugeAnimComplete(int index, int lastCP, int curCP)
		{
		}

		private void OnCPMatched(AbilityDataElement ade)
		{
		}

		public override IconType GetIconType()
		{
			return default(IconType);
		}
	}
}
