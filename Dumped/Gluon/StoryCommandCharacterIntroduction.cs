namespace Gluon
{
	[CommandName("chara_intro")]
	public class StoryCommandCharacterIntroduction : IStoryCommand
	{
		public void Start(string charaId, string name = "", string anotherName = "", string anotherNameRuby = "", string affiliation = "", string affiliationRuby = "", string emblemName = "")
		{
		}

		public string[] GetResourceNames(string charaId, string name = "", string anotherName = "", string anotherNameRuby = "", string affiliation = "", string affiliationRuby = "", string emblemName = "")
		{
			return null;
		}
	}
}
