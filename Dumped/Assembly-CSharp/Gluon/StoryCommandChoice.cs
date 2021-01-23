/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CommandName]
	public class StoryCommandChoice : IStoryCommand
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public int choiceNum;
			public string[] titleStrings;
			public string[] functionStrings;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal void _Start_b__0();
		}
	
		// Constructors
		public StoryCommandChoice();
	
		// Methods
		public void Start(string titleA, string functionA, string titleB, string functionB, string titleC = "", string functionC = "", string titleD = "", string functionD = "");
		public string[] GetResourceNames(string titleA, string functionA, string titleB, string functionB, string titleC = "", string functionC = "", string titleD = "", string functionD = "");
	}
}
