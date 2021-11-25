using System.Collections;

namespace Gluon
{
	[CommandName("cutt_load")]
	public class StoryCommandCuttLoad : IStoryCommand
	{
		private IEnumerator coroutine;

		public void Start(string cuttName)
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

		public string[] GetResourceNames(string cuttName)
		{
			return null;
		}
	}
}
