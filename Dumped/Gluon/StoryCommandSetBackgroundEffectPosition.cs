namespace Gluon
{
	[CommandName("set_BG_effect_pos")]
	public class StoryCommandSetBackgroundEffectPosition : IStoryCommand
	{
		public void Start(string effectId, float x, float y, float fadeSec = 0f, int ease = 1)
		{
		}

		private void SetBackgroundEffectPosition(string effectId, float x, float y, float fadeSec = 0f, int ease = 1)
		{
		}
	}
}
