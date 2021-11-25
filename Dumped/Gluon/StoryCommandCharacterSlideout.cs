using System.Collections;

namespace Gluon
{
	[CommandName("chara_slideout")]
	public class StoryCommandCharacterSlideout : IStoryCommand
	{
		private IEnumerator coroutine;

		private bool visible;

		private string charaId;

		private int type;

		private float sec;

		private bool fade;

		private float moveValue;

		public void Start(string charaId, int type, float sec, bool fade = true, float moveValue = 100f)
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
