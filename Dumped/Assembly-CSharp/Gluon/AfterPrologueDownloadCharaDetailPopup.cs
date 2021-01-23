/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AfterPrologueDownloadCharaDetailPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text charaName;
		public UnityEngine.UI.Text charaDescription;
		public UnityEngine.UI.Text skillName1;
		public UnityEngine.UI.Text skillName2;
		public UnityEngine.UI.Text skillDescription1;
		public UnityEngine.UI.Text skillDescription2;
		public Image[] skillIcons1;
		public Image[] skillIcons2;
		[CompilerGenerated]
		private int _charaId_k__BackingField;
		private Dictionary<string, int> skillIconNameToIndex;
	
		// Properties
		public int charaId { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public AfterPrologueDownloadCharaDetailPopup();
	
		// Methods
		public static AfterPrologueDownloadCharaDetailPopup CreateCharaDetailPopup(int charaId);
		protected override void Start();
	}
}
