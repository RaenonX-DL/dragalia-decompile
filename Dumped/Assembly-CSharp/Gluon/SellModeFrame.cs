/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SellModeFrame : MonoBehaviour
	{
		// Fields
		public Button sellButton;
		public Button autoSelectButton;
		public UnityEngine.UI.Text totalGoldText;
		public UnityEngine.UI.Text totalMoonext;
		public UnityEngine.UI.Text selectCountText;
		public UnityEngine.UI.Text autoSelectButtonText;
		public UnityEngine.UI.Text sellButtonText;
		public UnityEngine.UI.Text totalGold;
		public UnityEngine.UI.Text totalMoon;
		public UnityEngine.UI.Text selectCount;
		public GameObject totalMoonBase;
		public UnityAction<bool> backButtonCallBack;
		public UnityAction autoSelectButtonCallBack;
		public UnityAction sellButtonCallBack;
	
		// Constructors
		public SellModeFrame();
	
		// Methods
		private void Start();
		public void SetTotalTradeInPrice(long gold, int moon);
		public void SetSelectCount(int nowCount, int maxCount);
		public void SetSellListType(SellListType listType);
		public void BackButtonPressed();
		public void AutoSelectButtonPressed();
		public void SellButtonPressed();
	}
}
