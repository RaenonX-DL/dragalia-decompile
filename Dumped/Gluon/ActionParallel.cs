using System.Collections.Generic;

namespace Gluon
{
	public class ActionParallel : ActionBase
	{
		protected List<ActionBase> _actions;

		public ActionParallel(ActionBase[] actions)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		public override void RemoveSelf()
		{
		}
	}
}
