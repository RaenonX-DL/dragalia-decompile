/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageSeasonMoveMapList
	{
		// Fields
		private const int numOfScene = 21;
		private static MyPageSeasonMoveMapList _instance;
		public List<SceneInfo> sceneInfoList;
	
		// Properties
		public static MyPageSeasonMoveMapList instance { get; }
	
		// Nested types
		public class SceneInfo
		{
			// Fields
			public string mapName;
			public string sceneName;
			public string bgName;
			public MyPageTransitionController.MoveMapType mapType;
			public MyPageTransitionController.DayTimeType dayTimeType;
			public int fortLevel;
			public bool isRunning;
			public int[] characterIds;
	
			// Constructors
			public SceneInfo(string mapName, string sceneName, string bgName, MyPageTransitionController.MoveMapType mapType, MyPageTransitionController.DayTimeType dayTimeType, int fortLevel, bool isRunning);
		}
	
		// Constructors
		private MyPageSeasonMoveMapList();
		static MyPageSeasonMoveMapList();
	
		// Methods
		public static void DeleteInstance();
		public int GetSceneCount();
	}
}
