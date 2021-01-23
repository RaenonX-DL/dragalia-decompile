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
	public class GrowthConfirmDialog : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text confirmText;
		public ScrollRect iconListView;
		public GameObject itemIconOrigin;
		public GameObject materialIconOrigin;
		public Toggle deleteSRConfirmToggle;
		public Toggle deleteSSRConfirmToggle;
		public Toggle deleteLimitBreakMatConfirmToggle;
		public UnityEngine.UI.Text totalExpText;
		public UnityEngine.UI.Text deleteSRConfirmText;
		public UnityEngine.UI.Text deleteSSRConfirmText;
		public UnityEngine.UI.Text deleteLimitBreakConfirmText;
		public UnityEngine.UI.Text hpPlusText;
		public GameObject hpPlusBase;
		public UnityEngine.UI.Text atkPlusText;
		public GameObject atkPlusBase;
		[SerializeField]
		private UnityEngine.UI.Text totalGetExpText;
		private int checkToggleCount;
	
		// Constructors
		public GrowthConfirmDialog();
	
		// Methods
		public static GrowthConfirmDialog Create(bool showBlackLayer = false);
		public void SetupItemConfirm(Dictionary<int, int> itemDict);
		public void SetupMaterialConfirm(ConfigDialogSortData[] materialArray);
		public void SetAllExp(int exp);
		public void SetPlusParam(int hpPlus, int atkPlus);
		public void CheckTogglePressed(bool check);
	}
}
