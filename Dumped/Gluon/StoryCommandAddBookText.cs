using System.Collections;

namespace Gluon
{
	[CommandName("add_book_text")]
	public class StoryCommandAddBookText : IStoryCommand
	{
		private IEnumerator coroutine;

		private bool isEnd;

		private string text;

		private string fileName;

		private string logName;

		private string logVoice;

		public void Start(bool isEnd, string text = "", string fileName = "", string logName = "SYS", string logVoice = "")
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

		public string[] GetResourceNames(bool isEnd, string text = "", string fileName = "", string logName = "SYS", string logVoice = "")
		{
			return null;
		}
	}
}
