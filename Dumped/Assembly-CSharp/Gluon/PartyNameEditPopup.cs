/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyNameEditPopup : NameEditPopupBase
	{
		// Fields
		private int partyIndex;
	
		// Constructors
		public PartyNameEditPopup();
	
		// Methods
		public static PartyNameEditPopup Create();
		public void InitPopup(int partyIndex);
		protected override string GetInputFieldDefaultText();
	}
}
