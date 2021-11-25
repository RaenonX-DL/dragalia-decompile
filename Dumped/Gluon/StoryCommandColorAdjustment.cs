namespace Gluon
{
	[CommandName("color_adjustment")]
	public class StoryCommandColorAdjustment : IStoryCommand
	{
		public void Start(int cameraType = 1, float fadeSec = 0f, float bright = 1f, float saturation = 1f, float contrast = 1f)
		{
		}
	}
}
