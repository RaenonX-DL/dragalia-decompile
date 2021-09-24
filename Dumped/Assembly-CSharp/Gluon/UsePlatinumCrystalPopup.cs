/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UsePlatinumCrystalPopup : CommonPopup
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
		public GameObject skillLabelBase;
		public Transform skillListParentTransform;
		public GameObject originSkillIcon;
		public Transform materialListParentTransform;
		public GameObject originMaterialCell;
		public const int platinumCrystalMaterialId = 125001001;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<GrowthManaCircleManaPieceData, bool> __9__21_0;
			public static Func<GrowthManaCircleManaPieceData, int> __9__21_1;
			public static Func<GrowthManaCircleManaPieceData, int> __9__21_2;
			public static Func<GrowthManaCircleManaPieceData, bool> __9__22_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _InitPopup_b__21_0(GrowthManaCircleManaPieceData p);
			internal int _InitPopup_b__21_1(GrowthManaCircleManaPieceData p);
			internal int _InitPopup_b__21_2(GrowthManaCircleManaPieceData p);
			internal bool _GetCharaMaxGrowthMaxLevel_b__22_0(GrowthManaCircleManaPieceData p);
		}
	
		// Constructors
		public UsePlatinumCrystalPopup();
	
		// Methods
		public static UsePlatinumCrystalPopup Create();
		public void InitPopup(UnitDetailModel.CharaDetailData charaDetailData, GrowthManaCircleManaPieceData[] manaPieceDataList);
		public static int GetCharaMaxGrowthMaxLevel(GrowthManaCircleManaPieceData[] pieceDatas, CharaDataElement charaData);
		private void OnMaterialIconPressed(CraftMaterialCellData cellData);
	}
}
