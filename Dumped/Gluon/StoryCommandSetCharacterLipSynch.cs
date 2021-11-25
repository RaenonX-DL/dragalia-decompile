using System;

namespace Gluon
{
	[CommandName("chara_lipsynch")]
	public class StoryCommandSetCharacterLipSynch : IStoryCommand
	{
		public void Start(string charaId, float intervalMin = 71f / (339f * (float)Math.PI), float intervalMax = 71f / (339f * (float)Math.PI), float lipSynchingTime = 0.1f, int maxLipSynchFrame = 2)
		{
		}

		private void SetCharacterLipSynch(string charaId, float intervalMin, float intervalMax, float lipSynchingTime, int maxLipSynchFrame)
		{
		}
	}
}
