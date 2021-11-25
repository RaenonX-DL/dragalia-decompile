namespace Gluon
{
	[CommandName("next_script")]
	public class StoryCommandNextScript : IStoryCommand
	{
		public enum ScriptType
		{
			Main = 1,
			Event,
			Chara,
			Dragon,
			Castle,
			Tutorial
		}

		public void Start(string scriptName, int type = 1)
		{
		}

		public override bool Update()
		{
			return default(bool);
		}

		public string[] GetResourceNames(string scriptName, int type = 1)
		{
			return null;
		}
	}
}
