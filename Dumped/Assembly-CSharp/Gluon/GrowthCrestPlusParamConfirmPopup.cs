/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthCrestPlusParamConfirmPopup : CommonPopup
	{
		// Fields
		public Image[] itemIcons;
		public UnityEngine.UI.Text[] counts;
		public GameObject[] paramUIBase;
		public UnityEngine.UI.Text[] upParamLabelTexts;
		public UnityEngine.UI.Text[] upParamTexts;
		[CompilerGenerated]
		private int _hpPlusValue_k__BackingField;
		[CompilerGenerated]
		private int _atkPlusValue_k__BackingField;
	
		// Properties
		public int hpPlusValue { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int atkPlusValue { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public GrowthCrestPlusParamConfirmPopup();
	
		// Methods
		public static GrowthCrestPlusParamConfirmPopup Create();
		public void InitPopup(Dictionary<int, int> materialData);
	}
}
