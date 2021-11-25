namespace Gluon
{
	[CommandName("show_prologue_book")]
	public class ShowPrologueBook : IStoryCommand
	{
		public void Start(bool show, bool isTextPage = false)
		{
		}

		public string[] GetResourceNames(bool show, bool isTextPage = false)
		{
			return null;
		}
	}
}
