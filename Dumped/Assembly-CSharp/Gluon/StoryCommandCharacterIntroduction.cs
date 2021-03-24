/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CommandName]
	public class StoryCommandCharacterIntroduction : IStoryCommand
	{
		// Constructors
		public StoryCommandCharacterIntroduction();
	
		// Methods
		public void Start(string charaId, string name = "", string anotherName = "", string anotherNameRuby = "", string affiliation = "", string affiliationRuby = "", string emblemName = "");
		public string[] GetResourceNames(string charaId, string name = "", string anotherName = "", string anotherNameRuby = "", string affiliation = "", string affiliationRuby = "", string emblemName = "");
	}
}
