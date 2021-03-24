/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StampInfoPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private CommonIcon icon;
		[SerializeField]
		private UnityEngine.UI.Text stampName;
		private static readonly string popupPath;
	
		// Constructors
		public StampInfoPopup();
		static StampInfoPopup();
	
		// Methods
		public static StampInfoPopup Create(int stampId, bool showBlackLayer = true);
		private void SetupPopup(int stampId);
	}
}
