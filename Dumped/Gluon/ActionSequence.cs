using System.Collections.Generic;

namespace Gluon
{
	public class ActionSequence : ActionBase
	{
		protected List<ActionBase> _actions;

		private int _index;

		public ActionSequence(ActionBase[] actions)
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
