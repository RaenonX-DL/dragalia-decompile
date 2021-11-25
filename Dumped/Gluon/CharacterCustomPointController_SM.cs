using Gluon.Master;

namespace Gluon
{
	public class CharacterCustomPointController_SM : CharacterCustomPointController
	{
		private int lastCP;

		private int lastShikigamiBulletNum;

		private bool isDirtyCP;

		protected override void Initialize(CharacterBase owner, AbilityDataElement[] elems)
		{
		}

		public override void Update()
		{
		}

		public override void SetCP(int index, int value)
		{
		}

		public override IconType GetIconType()
		{
			return default(IconType);
		}
	}
}
