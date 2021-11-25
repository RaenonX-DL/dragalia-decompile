namespace Gluon.Dungeon.Gimmick
{
	public class ToggleDoor : DoorBase
	{
		private enum ToggleDoorStatus
		{
			NONE,
			OPEN,
			CLOSE
		}

		public ToggleSwitchColor color;

		protected int open;

		protected override void Start()
		{
		}

		public void Toggle()
		{
		}
	}
}
