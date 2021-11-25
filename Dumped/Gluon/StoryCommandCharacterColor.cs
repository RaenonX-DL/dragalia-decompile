namespace Gluon
{
	[CommandName("chara_color")]
	public class StoryCommandCharacterColor : IStoryCommand
	{
		public void Start(string charaId, float fadeSec, int type, int r, int g, int b, float a = 1f, float smoothMin = 0f, float smoothMax = 1f)
		{
		}
	}
}
