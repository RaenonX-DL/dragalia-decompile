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
	public class CharaGimmickInputCtrl
	{
		// Fields
		private Dictionary<CharacterBase, Dictionary<int, CharaGimmickBaseInputUI>> _inputUIDic;
	
		// Nested types
		public enum InputUIType
		{
			None = 0,
			AddCountInput = 1,
			AddGaugeInput = 2
		}
	
		// Constructors
		public CharaGimmickInputCtrl();
	
		// Methods
		public void Attach(CharacterBase chara);
		private bool IsRegistered(CharacterBase owner, int actionId);
		public void Show(CharacterBase owner);
		public void Hide(CharacterBase owner, bool anim);
		public void Hide(bool anim);
		public bool IsVisible(CharacterBase owner);
		public void SetCount(CharacterBase owner, int num, bool force = false, bool immediate = false);
		private int GetCurrentActionId(CharacterBase chara);
	}
}
