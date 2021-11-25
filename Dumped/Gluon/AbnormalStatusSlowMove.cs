using Gluon.Master;

namespace Gluon
{
	public class AbnormalStatusSlowMove : AbnormalStatusBase
	{
		public override void Setup(CharacterBase chara, CollisionHitAttribute attr, ActionConditionElement elem, bool overrideEffect)
		{
		}

		public override void Exit()
		{
		}

		public override bool Update()
		{
			return default(bool);
		}
	}
}
