using System.Runtime.InteropServices;
using Gluon.ActionData;

namespace Gluon.Bullet
{
	public class ActionPartsNevOption : ActionPartsBullet
	{
		private readonly NevOptionData _partsData;

		public ActionPartsNevOption(Gluon.ActionData.ActionParts resource)
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

		public void OnFire([Optional] CharacterBase chara)
		{
		}

		public override int[] GetActionIdsForLoad()
		{
			return null;
		}
	}
}
