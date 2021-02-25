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
	public class ModeSelectButtonCtrl
	{
		// Fields
		private Dictionary<CharacterBase, List<ModeSelectButton>> _charaSelectorDic;
		private List<CharacterBase> _workCharaList;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public ModeSelectButtonCtrl __4__this;
			public HumanCharacter human;
			public ModeSelectButton.ButtonDelegate __9__0;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _Attach_b__0(ModeSelectButton sender);
		}
	
		// Constructors
		public ModeSelectButtonCtrl();
	
		// Methods
		public void Reset();
		public void Attach(HumanCharacter human);
		public void Update();
		public void ApplyMode(CharacterBase chara, bool playSe = true, bool force = false);
		public void ApplyLayoutStyle();
	}
}
