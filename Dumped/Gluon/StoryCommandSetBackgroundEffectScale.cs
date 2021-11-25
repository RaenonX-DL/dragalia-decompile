namespace Gluon
{
	[CommandName("set_BG_effect_scale")]
	public class StoryCommandSetBackgroundEffectScale : IStoryCommand
	{
		public void Start(string effectId, float x, float y, float fadeSec = 0f, int ease = 1, float baseX = -1f, float baseY = -1f)
		{
		}

		private void SetBackgroundEffectScale(string effectId, float x, float y, float fadeSec = 0f, int ease = 1, float baseX = -1f, float baseY = -1f)
		{
		}
	}
}
