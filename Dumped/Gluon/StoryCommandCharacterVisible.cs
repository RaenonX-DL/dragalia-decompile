namespace Gluon
{
	[CommandName("chara_visible")]
	public class StoryCommandCharacterVisible : IStoryCommand
	{
		public void Start(string charaId, bool flag)
		{
		}

		public string[] GetResourceNames(string charaId, bool flag)
		{
			return null;
		}

		public void SetCharaVisible(string charaId, bool flag)
		{
		}
	}
}
