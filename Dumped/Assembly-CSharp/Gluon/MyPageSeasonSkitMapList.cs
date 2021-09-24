/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageSeasonSkitMapList
	{
		// Fields
		private static MyPageSeasonSkitMapList _instance;
		public List<SceneInfo> sceneInfoList;
		private const int numOfScene = 21;
	
		// Properties
		public static MyPageSeasonSkitMapList instance { get; }
	
		// Nested types
		public class SceneInfo
		{
			// Fields
			public string mapName;
			public string sceneName;
			public int[] characterIds;
	
			// Constructors
			public SceneInfo(string mapName, string sceneName);
		}
	
		// Constructors
		private MyPageSeasonSkitMapList();
		static MyPageSeasonSkitMapList();
	
		// Methods
		public static void DeleteInstance();
		public int GetSceneCount();
	}
}
