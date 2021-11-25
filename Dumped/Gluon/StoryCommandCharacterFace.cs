namespace Gluon
{
	[CommandName("chara_face")]
	public class StoryCommandCharacterFace : IStoryCommand
	{
		public void Start(string charaId, int faceId, int faceNum = 0)
		{
		}

		private void SetCharacterFace(string charaId, int faceId, int faceNum)
		{
		}

		public string[] GetResourceNames(string charaId, int faceId, int faceNum = 0)
		{
			return null;
		}
	}
}
