using System.Collections;

namespace Gluon
{
	[CommandName("cutscene_wait")]
	public class StoryCommandCutSceneWait : IStoryCommand
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
