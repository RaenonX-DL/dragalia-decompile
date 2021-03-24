/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowResultStatusDialog : CommonPopup
	{
		// Fields
		public Image baseIcon;
		public GrowResultDiffParam growResultDiffParam;
		public GrowResultGetSkill growResultGetSkill;
		public GameObject growResultLimitLevel;
		public GrowResultDialogType goOtherSceneResultType;
		[SerializeField]
		private UnityEngine.UI.Text lvText;
		[SerializeField]
		private UnityEngine.UI.Text hpText;
		[SerializeField]
		private UnityEngine.UI.Text atkText;
		[SerializeField]
		private UnityEngine.UI.Text powerText;
		private List<GrowResultDialogType> resultStateList;
		private GrowResultBaseData oldBaseData;
		private GrowResultBaseData newBaseData;
	
		// Constructors
		public GrowResultStatusDialog();
	
		// Methods
		public static GrowResultStatusDialog Create(bool showBlackLayer = false, GrowthBaseType growthBaseType = GrowthBaseType.Weapon);
		public void SetupResultDialog(GrowResultBaseData oldData, GrowResultBaseData updateData, bool isLimitBreak);
		public void LimitBreakPressed();
		public void CancelButtonPressed();
		private void ShowDialog();
		private void ShowDiffParam();
		private void ShowMaxLevel(GrowResultDialogType type);
		private void ShowMaxPlus();
		private void ClosePop();
		[CompilerGenerated]
		private void _SetupResultDialog_b__13_0();
	}
}
