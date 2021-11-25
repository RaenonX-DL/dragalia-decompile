using System.Collections;

namespace Gluon.Dungeon.Gimmick
{
	public class TimedDoor : DoorBase
	{
		[Lock]
		public TimedSwitchColor color;

		private IEnumerator Action(float time)
		{
			return null;
		}

		public void StartAction(float time)
		{
		}
	}
}
