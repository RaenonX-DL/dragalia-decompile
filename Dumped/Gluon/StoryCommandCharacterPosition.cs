using UnityEngine;

namespace Gluon
{
	[CommandName("chara_pos")]
	public class StoryCommandCharacterPosition : IStoryCommand
	{
		public void Start(string charaId, int valueX = 0, int valueY = 0)
		{
		}

		private void SetPosition(string charaId, Vector2 position)
		{
		}
	}
}
