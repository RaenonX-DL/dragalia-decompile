namespace Gluon
{
	[CommandName("set_BG_effect_rotation")]
	public class StoryCommandSetBackgroundEffectRotation : IStoryCommand
	{
		public void Start(string effectId, float value, float fadeSec = 0f, int ease = 1)
		{
		}

		private void SetBackgroundEffectRotation(string effectId, float value, float fadeSec = 0f, int ease = 1)
		{
		}
	}
}
