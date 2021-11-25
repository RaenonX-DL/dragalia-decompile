namespace Gluon
{
	[CommandName("chara_eyeblink")]
	public class StoryCommandSetCharacterEyeBlink : IStoryCommand
	{
		public void Start(string charaId, float intervalMin = 2f, float intervalMax = 5f, float eyeBlinkingTime = 0.05f, int maxEyeBlinkFrame = 2)
		{
		}

		private void SetCharacterEyeBlink(string charaId, float intervalMin, float intervalMax, float eyeBlinkingTime, int eyeBlinkCutNum)
		{
		}
	}
}
