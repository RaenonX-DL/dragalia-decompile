using Gluon.Master;

namespace Gluon
{
	public class CharacterCustomPointController_SSR : CharacterCustomPointController
	{
		public override int maxCP => default(int);

		protected override void Initialize(CharacterBase owner, AbilityDataElement[] elems)
		{
		}

		public override void Update()
		{
		}

		public override void SetCP(int index, int value)
		{
		}

		private void OnGaugeAnimComplete(int index, int prevCP, int currCP)
		{
		}

		private void OnCPMatched(AbilityDataElement ade, int skillId, int skillIndex)
		{
		}

		public override IconType GetIconType()
		{
			return default(IconType);
		}

		public override bool ClearCPOnContinue()
		{
			return default(bool);
		}
	}
}
