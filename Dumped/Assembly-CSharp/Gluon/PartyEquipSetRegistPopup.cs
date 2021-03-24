/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyEquipSetRegistPopup : CommonPopup
	{
		// Fields
		public Image charaIcon;
		public UnityEngine.UI.Text charaNameText;
		public PartyEquipSetPopupCell fromSetCell;
		public PartyEquipSetPopupCell toSetCell;
		private int charaId;
	
		// Constructors
		public PartyEquipSetRegistPopup();
	
		// Methods
		public static PartyEquipSetRegistPopup Create();
		public void InitPopup(int charaId, int setIndex);
		public void OnCharaIconPressed();
	}
}
