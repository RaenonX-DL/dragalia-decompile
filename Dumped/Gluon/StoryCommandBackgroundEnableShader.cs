namespace Gluon
{
	[CommandName("bg_enable_shader")]
	public class StoryCommandBackgroundEnableShader : IStoryCommand
	{
		private enum ShaderFuncs
		{
			Front1,
			Front2,
			Back1,
			Back2
		}

		private string[] callFuncNames;

		public void Start(string bgId, bool[] enables)
		{
		}
	}
}
