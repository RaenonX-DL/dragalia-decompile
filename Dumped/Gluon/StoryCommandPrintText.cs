using System.Collections;

namespace Gluon
{
	[CommandName("print")]
	public class StoryCommandPrintText : IStoryCommand
	{
		private IEnumerator coroutine;

		private bool isEnd;

		private string name;

		private string text;

		private string voice;

		private bool isVisiblePageIcon;

		private bool isEndLipSynch;

		private string overLineText;

		private const string hideTrigger = "#";

		private const string hideSecondTrigger = "$";

		public const int waitFrameCountForDummyVoiceCheck = 5;

		public void Start(bool isEnd, string name = "", string text = "", string voice = "")
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

		private void UpdateLipSynch()
		{
		}

		public string[] GetResourceNames(bool isEnd, string name = "", string text = "", string voice = "")
		{
			return null;
		}

		private IEnumerator _UpdateWindowFadein()
		{
			return null;
		}

		public static bool IsExistVoice(string voice)
		{
			return default(bool);
		}

		private static CuttDriverInGame GetCuttDriver()
		{
			return null;
		}
	}
}
