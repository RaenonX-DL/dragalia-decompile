using System.Collections;

namespace Gluon
{
	[CommandName("touch_wait")]
	public class StoryCommandTouchWait : IStoryCommand
	{
		private IEnumerator coroutine;

		private bool isAutoWaitEnable;

		private bool isForceNext;

		private float forceNextWaitTime;

		public void Start(float autoWaitTime = 0f, float forceNextWaitTime = -1f)
		{
		}

		public override bool Update()
		{
			return default(bool);
		}

		private IEnumerator _Update()
		{
			return null;
		}
	}
}
