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
	public class CharacterLoadBalancer
	{
		// Fields
		private List<CharacterSelector> _alwaysCharacterSelectors;
		private List<CharacterSelector> _sparseCharacterSelectors;
	
		// Constructors
		public CharacterLoadBalancer();
	
		// Methods
		public void AddCharacter(CharacterSelector selector, bool isOtherPlayerCharacter);
		public void RemoveCharacter(CharacterSelector selector);
		public void InactivateOtherPlayer(CharacterSelector c);
		public void Update();
		public bool CanExecTask(CharacterBase character);
		private bool IsSameCharacter(CharacterSelector selector, CharacterBase chara);
	}
}
