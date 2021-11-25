using System.Collections;

namespace Gluon
{
	[CommandName("cutt_waitevent")]
	public class StoryCommandCuttWaitEvent : IStoryCommand
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
