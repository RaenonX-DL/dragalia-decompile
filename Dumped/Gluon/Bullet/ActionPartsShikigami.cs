using Gluon.ActionData;

namespace Gluon.Bullet
{
	public class ActionPartsShikigami : ActionPartsBullet
	{
		private readonly ShikigamiData _partsData;

		public ActionPartsShikigami(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override void Fire()
		{
		}

		public override int[] GetActionIdsForLoad()
		{
			return null;
		}
	}
}
