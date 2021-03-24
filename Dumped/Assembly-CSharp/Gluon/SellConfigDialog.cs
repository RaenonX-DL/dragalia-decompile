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
	public class SellConfigDialog : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text topMessages;
		public ScrollRect iconListView;
		public GameObject selectIconOrigin;
		public GameObject deleteLimitBreakConfirmToggle;
		public GameObject deleteSRConfirmToggle;
		public GameObject deleteSSRConfirmToggle;
		public GameObject deleteOverGoldConfirmToggle;
		public GameObject plusUnitConfirmToggle;
		public GameObject moonOverflowCaution;
		public UnityEngine.UI.Text limitBreakConfirmMessage;
		public UnityEngine.UI.Text ssrConfirmMessage;
		public UnityEngine.UI.Text srConfirmMessage;
		public UnityEngine.UI.Text overGoldConfirmMessage;
		public UnityEngine.UI.Text plusUnitConfirmMessage;
		public UnityEngine.UI.Text totalGoldText;
		public UnityEngine.UI.Text totalMoonText;
		public UnityEngine.UI.Text beforeGold;
		public UnityEngine.UI.Text totalGold;
		public UnityEngine.UI.Text beforeMoon;
		public UnityEngine.UI.Text totalMoon;
		public GameObject totalMoonBase;
		private ConfigDialogSortData[] selectUserData;
		private long beforeGoldValue;
		private long gold;
		private int beforeMoonValue;
		private int moon;
		private Color valueColorSame;
		private Color valueColorDiff;
		private int checkToggleCount;
	
		// Constructors
		public SellConfigDialog();
	
		// Methods
		public static SellConfigDialog Create(bool showBlackLayer = true);
		protected override void Start();
		public void SetupSellConfirm(ConfigDialogSortData[] selectUserData, long gold, int moon, long beforeGoldValue, int beforeMoonValue);
		public void SetupSellComplete(ConfigDialogSortData[] selectUserData, long gold, int moon, long beforeGoldValue, int beforeMoonValue);
		private void SetText(long gold, int moon, long beforeGoldValue, int beforeMoonValue);
		public void CheckTogglePressed(bool check);
	}
}
