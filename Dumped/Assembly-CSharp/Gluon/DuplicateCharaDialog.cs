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
	public class DuplicateCharaDialog : CommonPopup
	{
		// Fields
		public Image charaIcon;
		public UnityEngine.UI.Text charaName;
	
		// Constructors
		public DuplicateCharaDialog();
	
		// Methods
		public static DuplicateCharaDialog Create(bool showBlackLayer = true);
		public void SetupDuplicateCharaData(int charaId, int rarity);
	}
}
