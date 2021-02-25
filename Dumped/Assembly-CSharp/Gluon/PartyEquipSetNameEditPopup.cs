/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyEquipSetNameEditPopup : NameEditPopupBase
	{
		// Fields
		private int charaId;
		private int setIndex;
	
		// Constructors
		public PartyEquipSetNameEditPopup();
	
		// Methods
		public static PartyEquipSetNameEditPopup Create();
		public void InitPopup(int charaId, int setIndex);
		protected override string GetInputFieldDefaultText();
	}
}
