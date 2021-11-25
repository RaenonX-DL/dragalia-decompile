using System.Collections;

namespace Gluon
{
	[CommandName("telop")]
	public class StoryCommandTelop : IStoryCommand
	{
		private IEnumerator coroutine;

		private string mainText;

		private string subText;

		private string mainRuby;

		private string subRuby;

		public void Start(string mainText, string subText = "", string mainRuby = "", string subRuby = "")
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
