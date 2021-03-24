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
	public class LimitResultDialog : CommonPopup
	{
		// Fields
		public GameObject growResultLimitStar;
		public LimitStarBase beforeLimitStar;
		public LimitStarBase afterLimitStar;
		public Image baseIcon;
		public UnityEngine.UI.Text beforeLimitLevel;
		public UnityEngine.UI.Text afterLimitLevel;
		public GrowResultGetSkill growResultGetSkill;
		public Transform amuletBase;
		public Image beforeIcon;
		public Image afterIcon;
		public Transform limitBreakParam;
		public Transform levelMaxParam;
		[SerializeField]
		private UnityEngine.UI.Text resultText;
		[SerializeField]
		private UnityEngine.UI.Text starText;
		[SerializeField]
		private UnityEngine.UI.Text lvText;
		[SerializeField]
		private UnityEngine.UI.Text getSkillText;
		[SerializeField]
		private UnityEngine.UI.Text amuletText;
		private List<GrowResultDialogType> resultStateList;
		private GrowResultBaseData oldBaseData;
		private GrowResultBaseData newBaseData;
		public Action<GrowResultDialogType> closeButtonCallBack;
		public bool isReleaseAmuletLv3;
	
		// Constructors
		public LimitResultDialog();
	
		// Methods
		public static LimitResultDialog Create(bool showBlackLayer = false);
		public void SetupResultDialog(GrowResultBaseData oldData, GrowResultBaseData updateData);
		public void OnToPowerupButtonPressed();
		private void GoGrowthScene();
		public void OKButtonPressed();
		private void ShowDialog();
		private void ShowDiffLimit();
		private bool ShowPowerUpSkill(GrowResultDialogType type);
		private void SetBottomButton();
		[CompilerGenerated]
		private void _SetupResultDialog_b__23_0();
		[CompilerGenerated]
		private void _OnToPowerupButtonPressed_b__24_0();
	}
}
