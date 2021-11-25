namespace Gluon
{
	[CommandName("message_pos")]
	public class StoryCommandMessagePosition : IStoryCommand
	{
		private enum Type
		{
			MessageWindow,
			ChapterIntroduction
		}

		public void Start(float[] pos)
		{
		}
	}
}
