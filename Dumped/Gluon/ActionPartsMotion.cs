using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsMotion : ActionParts
	{
		private readonly PartsMotionData _partsData;

		public string motion => null;

		public ActionPartsMotion(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		public override void Clear()
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}
	}
}
