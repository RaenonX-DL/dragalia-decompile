namespace Gluon
{
	[CommandName("choice")]
	public class StoryCommandChoice : IStoryCommand
	{
		public void Start(string titleA, string functionA, string titleB, string functionB, string titleC = "", string functionC = "", string titleD = "", string functionD = "")
		{
		}

		public string[] GetResourceNames(string titleA, string functionA, string titleB, string functionB, string titleC = "", string functionC = "", string titleD = "", string functionD = "")
		{
			return null;
		}
	}
}
