namespace Gluon.Dungeon.Gimmick
{
	public abstract class DelayedGimmickBase : GimmickBase
	{
		public GimmickDelayType delayType;

		public float delaySec;

		protected override void Awake()
		{
		}
	}
}
