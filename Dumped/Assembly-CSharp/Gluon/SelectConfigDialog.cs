/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SelectConfigDialog : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text topMessages;
		public ScrollRect iconListView;
		public GameObject selectIconOrigin;
		public GameObject deleteSRConfirmToggle;
		public GameObject deleteSSRConfirmToggle;
		public GameObject deleteOverGoldConfirmToggle;
		public UnityEngine.UI.Text ssrConfirmMessage;
		public UnityEngine.UI.Text srConfirmMessage;
		public UnityEngine.UI.Text overGoldConfirmMessage;
		public UnityEngine.UI.Text totalGoldText;
		public UnityEngine.UI.Text totalGold;
		public UnityEngine.UI.Text totalMoon;
		private ConfigDialogSortData[] selectUserData;
		private int gold;
		private int moon;
		private int checkToggleCount;
	
		// Constructors
		public SelectConfigDialog();
	
		// Methods
		public static SelectConfigDialog Create(bool showBlackLayer = true);
		protected override void Start();
		public void SetupSelectConfirm(ConfigDialogSortData[] selectUserData, int gold, int moon);
		public void SetupSellComplete(ConfigDialogSortData[] selectUserData, int gold, int moon);
		public void CheckTogglePressed(bool check);
	}
}
