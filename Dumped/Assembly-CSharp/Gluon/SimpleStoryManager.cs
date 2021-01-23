/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SimpleStoryManager : MonoBehaviour
	{
		// Fields
		public CameraGroup characterCamera;
		private GameObject storyCanvasObject;
		private GameObject storyBgCanvasObject;
		private GameObject storyCharaCanvasObject;
	
		// Nested types
		private enum SortingOrder
		{
			Character = 150,
			UIBackground = 151,
			UIMain = 152
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public SimpleStoryManager __4__this;
			public Action onCompleted;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _ExecScript_b__0(StoryScriptFunctionManager.State state, StoryScriptFunctionManager.ScriptFunction index);
		}
	
		// Constructors
		public SimpleStoryManager();
	
		// Methods
		public void SetupStory();
		public void ExecScript(string scriptName, Action onCompleted);
	}
}
