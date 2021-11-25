using UnityEngine;

namespace Gluon
{
	[CommandName("set_BG_effect_color")]
	public class StoryCommandSetBackgroundEffectColor : IStoryCommand
	{
		public void Start(string effectId, int r, int g, int b, float a = 1f, float fadeSec = 0f, int ease = 1)
		{
		}

		private void SetBackgroundEffectColor(string effectId, Color color, float fadeSec = 0f, int ease = 1)
		{
		}
	}
}
