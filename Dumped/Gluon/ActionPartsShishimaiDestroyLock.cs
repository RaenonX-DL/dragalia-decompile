using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsShishimaiDestroyLock : ActionParts
	{
		private readonly ShishimaiDestroyLockData _partsData;

		private bool _isOpenBoxDone;

		public ActionPartsShishimaiDestroyLock(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override void OnStart()
		{
		}

		public override void Clear()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}
	}
}
