using System.Collections;

namespace Gluon
{
	[CommandName("cutt_waittap")]
	public class StoryCommandCuttWaitTap : IStoryCommand
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
