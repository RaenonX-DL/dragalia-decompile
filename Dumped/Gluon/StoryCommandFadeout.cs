using System.Collections;

namespace Gluon
{
	[CommandName("chara_fadeout")]
	public class StoryCommandFadeout : IStoryCommand
	{
		private IEnumerator coroutine;

		private bool visible;

		private string charaId;

		private float sec;

		public void Start(string charaId, float sec)
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
