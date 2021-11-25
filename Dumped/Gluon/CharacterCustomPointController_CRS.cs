using System.Collections.Generic;
using Gluon.Master;

namespace Gluon
{
	public class CharacterCustomPointController_CRS : CharacterCustomPointController
	{
		protected List<float> conditionValueList;

		public override int maxCP => default(int);

		protected override void Initialize(CharacterBase owner, AbilityDataElement[] elems)
		{
		}

		public override void AttachToUI()
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

		public override bool ClearCPOnReborn()
		{
			return default(bool);
		}

		public override int GetChargeLevel()
		{
			return default(int);
		}
	}
}
