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
	public class GrowthManaCircleAutoReleasePopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text topMessageText;
		public GameObject statusLabelBase;
		public GameObject statusHPBase;
		public UnityEngine.UI.Text statusHPBefore;
		public UnityEngine.UI.Text statusHPAfter;
		public GameObject statusAtkBase;
		public UnityEngine.UI.Text statusAtkBefore;
		public UnityEngine.UI.Text statusAtkAfter;
		public GameObject statusLevelBase;
		public UnityEngine.UI.Text statusLevelBefore;
		public UnityEngine.UI.Text statusLevelAfter;
		public GameObject statusComboBase;
		public UnityEngine.UI.Text statusComboBefore;
		public UnityEngine.UI.Text statusComboAfter;
		public GameObject manaPointBase;
		public UnityEngine.UI.Text manaPointBefore;
		public UnityEngine.UI.Text manaPointAfter;
		public GameObject dewBase;
		public UnityEngine.UI.Text dewBefore;
		public UnityEngine.UI.Text dewAfter;
		public GameObject skillLabelBase;
		public Transform skillListParentTransform;
		public GameObject originSkillIcon;
		public Transform materialListParentTransform;
		public GameObject originMaterialCell;
		public UnityEngine.UI.Text warningText;
	
		// Constructors
		public GrowthManaCircleAutoReleasePopup();
	
		// Methods
		public static GrowthManaCircleAutoReleasePopup Create();
		public void InitPopup(GrowthManaCircleModel model, GrowthManaCircleManaPieceData[] pieceDatas, int requiredMP, int requiredDew);
		private void SetMaterialDataDict(int materialId, int needCount, ref Dictionary<int, int> materialDict);
		private void OnMaterialIconPressed(CraftMaterialCellData cellData);
	}
}
