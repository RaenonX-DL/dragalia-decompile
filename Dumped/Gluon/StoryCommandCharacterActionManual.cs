namespace Gluon
{
	[CommandName("chara_act_manual")]
	public class StoryCommandCharacterActionManual : IStoryCommand
	{
		public void Start(string charaId, bool isNewAct, float moveSec, float moveX, float moveY, int moveEase, float scaleSec = 0f, float scaleX = 0f, float scaleY = 0f, int scaleEase = 0, float rotateSec = 0f, float rotate = 0f, int rotateEase = 0, float fadeSec = 0f, float fade = 0f, int fadeEase = 0)
		{
		}
	}
}
