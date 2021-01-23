/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryOutlinePopup : CommonPopup
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Story/StoryOutlinePopup";
		[SerializeField]
		private RectTransform textRootRect;
		[SerializeField]
		private UnityEngine.UI.Text textBase;
		[SerializeField]
		private RectTransform textParentBase;
		private RectTransform[] textParents;
		private int lineMax;
		private int lineLetterMax;
		private string baseOutlineString;
		private int tempShowLetterNum;
		private float[] widths;
		private float rubyUpCoefficient;
		private float rubySizeCoefficient;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public StoryOutlinePopup __4__this;
			public bool isPausedMovie;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _InitSetting_b__0();
			internal void _InitSetting_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public string nextSceneName;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _EndScript_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__15_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _EndScript_b__15_0();
		}
	
		// Constructors
		public StoryOutlinePopup();
	
		// Methods
		public static StoryOutlinePopup Create();
		public void InitSetting();
		public void AddOutlineText(string outlineString, string rubyString, bool isEnd);
		public static void EndScript();
	}
}
