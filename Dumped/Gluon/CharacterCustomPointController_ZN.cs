using System;
using Gluon.Master;

namespace Gluon
{
	public class CharacterCustomPointController_ZN : CharacterCustomPointController
	{
		private int lastCP;

		protected override void Initialize(CharacterBase owner, AbilityDataElement[] elems)
		{
		}

		public override void SetCP(int index, int value)
		{
		}

		private void OnGaugeAnimComplete(int index)
		{
		}

		private void ApplyUIEffect(Action onUIDone)
		{
		}

		private void OnCPMatched(AbilityDataElement ade)
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

		public override void OnContinue()
		{
		}
	}
}
