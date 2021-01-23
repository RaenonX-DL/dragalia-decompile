/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryCommandExecuter : FastUpdateMonoBehaviour
	{
		// Fields
		public StoryScriptRuntime storyScript;
		private BaseScript _commonScript;
		[CompilerGenerated]
		private static StoryCommandExecuter _instance_k__BackingField;
	
		// Properties
		public BaseScript CommonScript { get; }
		public static StoryCommandExecuter instance { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public StoryCommandExecuter();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		public void StartStoryFromPath(string path, bool isDefault = true);
		public void StartStory(StoryScript storyScript, bool isDefault = true);
		public void StartStory(StoryScriptRuntime storyScript, bool isDefault = true);
		public void CallFunction(string functionName);
		public static string[] CollectResourceNamesForScriptPath(string scriptPath, bool useAsset = true);
		public override void FastUpdate();
		public void EndStory();
	}
}
