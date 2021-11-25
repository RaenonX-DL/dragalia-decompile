using System.Collections;

namespace Gluon
{
	[CommandName("cutt_waitevent_disable_skip")]
	public class StoryCommandCuttWaitEventDisableSkip : IStoryCommand
	{
		private IEnumerator coroutine;

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
