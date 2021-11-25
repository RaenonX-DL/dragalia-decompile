using System.Collections;
using DG.Tweening;

namespace Gluon
{
	[CommandName("chara_slidein")]
	public class StoryCommandCharacterSlidein : IStoryCommand
	{
		private IEnumerator coroutine;

		private bool visible;

		private string charaId;

		private int type;

		private float sec;

		private bool fade;

		private float moveValue;

		private Tweener tween;

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
