namespace Gluon
{
	[CommandName("set_BG_effect_speed")]
	public class StoryCommandSetBackgroundEffectSpeed : IStoryCommand
	{
		public void Start(string effectId, float value, float fadeSec = 0f, int ease = 1)
		{
		}

		private void SetBackgroundEffectSpeed(string effectId, float value, float fadeSec = 0f, int ease = 1)
		{
		}
	}
}
