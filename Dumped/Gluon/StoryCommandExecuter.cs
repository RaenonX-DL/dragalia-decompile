using System.Runtime.CompilerServices;
using Cute.Core;

namespace Gluon
{
	public class StoryCommandExecuter : FastUpdateMonoBehaviour
	{
		public StoryScriptRuntime storyScript;

		private BaseScript _commonScript;

		public BaseScript CommonScript => null;

		public static StoryCommandExecuter instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void StartStoryFromPath(string path, bool isDefault = true)
		{
		}

		public void StartStory(StoryScript storyScript, bool isDefault = true)
		{
		}

		public void StartStory(StoryScriptRuntime storyScript, bool isDefault = true)
		{
		}

		public void CallFunction(string functionName)
		{
		}

		public static string[] CollectResourceNamesForScriptPath(string scriptPath, bool useAsset = true)
		{
			return null;
		}

		public override void FastUpdate()
		{
		}

		public void EndStory()
		{
		}
	}
}
