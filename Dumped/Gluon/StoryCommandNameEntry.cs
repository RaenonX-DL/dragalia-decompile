using System.Collections;

namespace Gluon
{
	[CommandName("name_entry")]
	public class StoryCommandNameEntry : IStoryCommand
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
