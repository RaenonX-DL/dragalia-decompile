namespace Gluon
{
	[CommandName("set_BG_effect_opacity")]
	public class StoryCommandSetBackgroundEffectOpacity : IStoryCommand
	{
		public void Start(string effectId, float value, float fadeSec = 0f, int ease = 1)
		{
		}

		private void SetBackgroundEffectOpacity(string effectId, float value, float fadeSec = 0f, int ease = 1)
		{
		}
	}
}
