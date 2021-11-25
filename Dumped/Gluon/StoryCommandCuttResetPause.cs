using System.Collections;

namespace Gluon
{
	[CommandName("cutt_resetpause")]
	public class StoryCommandCuttResetPause : IStoryCommand
	{
		private IEnumerator coroutine;

		private bool isReset;

		public void Start()
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
