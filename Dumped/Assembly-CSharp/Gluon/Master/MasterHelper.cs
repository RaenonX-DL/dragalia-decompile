/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	public class MasterHelper
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public int charaId;
			public int category0;
			public int category1;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal bool _GetCharaTalk_b__0(CharaTalkElement e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0
		{
			// Fields
			public int charaId;
			public int category0;
			public int category1;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal bool _GetDragonTalk_b__0(DragonTalkElement e);
		}
	
		// Constructors
		public MasterHelper();
	
		// Methods
		public static List<CharaTalkElement> GetCharaTalk(int charaId, int category0, int category1);
		public static List<DragonTalkElement> GetDragonTalk(int charaId, int category0, int category1);
	}
}
