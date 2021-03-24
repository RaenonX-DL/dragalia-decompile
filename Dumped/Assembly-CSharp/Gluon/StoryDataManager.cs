/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryDataManager
	{
		// Fields
		private const string questMainPath = "Story/QuestStory/Main/";
		private const string questEventPath = "Story/QuestStory/Event/";
		private const string unitCharaPath = "Story/UnitStory/Chara/";
		private const string unitDragonPath = "Story/UnitStory/Dragon/";
		private const string castlePath = "Story/CastleStory/";
		private const string tutorialPath = "Story/tutorial/";
		private static readonly string[] commonScriptNames;
		public static string scriptPath;
		public static string nextScene;
		public static bool isSampleStory;
	
		// Nested types
		public enum UnitGroupType
		{
			None = 0,
			Chara = 1,
			Dragon = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public string path;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal bool _IsCommonScript_b__0(string s);
		}
	
		// Constructors
		public StoryDataManager();
		static StoryDataManager();
	
		// Methods
		public static string GetQuestScriptPath(QuestGroupType type, string fileName = "");
		public static string GetUnitScriptPath(UnitGroupType type, string fileName = "");
		public static string GetCastleScriptPath(string fileName = "");
		public static string GetTutorialScriptPath(string fileName = "");
		public static StoryScript LoadStoryScript(string filePath);
		public static BaseScript LoadCommonStoryScript();
		public static bool IsCommonScript(string path);
	}
}
