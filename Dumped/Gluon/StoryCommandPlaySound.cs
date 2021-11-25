using System.Collections;

namespace Gluon
{
	[CommandName("play_sound")]
	public class StoryCommandPlaySound : IStoryCommand
	{
		private IEnumerator coroutine;

		private string soundStr;

		private float vol;

		private bool isAvoidDupricateVoice;

		private bool isAddTextLog;

		public void Start(string soundStr, float vol = 1f, bool isAvoidDupricateVoice = true, bool isAddTextLog = true)
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

		public void PlaySound()
		{
		}

		public string[] GetResourceNames(string soundStr, float vol = 1f, bool isAvoidDupricateVoice = true, bool isAddTextLog = true)
		{
			return null;
		}
	}
}
