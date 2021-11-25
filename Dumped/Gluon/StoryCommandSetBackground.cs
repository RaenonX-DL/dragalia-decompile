namespace Gluon
{
	[CommandName("set_BG")]
	public class StoryCommandSetBackground : IStoryCommand
	{
		public void Start(string[] backgroundIds)
		{
		}

		public string[] GetResourceNames(string[] backgroundIds)
		{
			return null;
		}
	}
}
