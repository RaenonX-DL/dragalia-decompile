namespace Gluon
{
	[CommandName("set_camera_distortion")]
	public class StoryCommandSetCameraDistortion : IStoryCommand
	{
		public void Start(int cameraType, bool enable, string effectId = "")
		{
		}

		private void SetCameraDistortion(int cameraType, bool enable)
		{
		}
	}
}
