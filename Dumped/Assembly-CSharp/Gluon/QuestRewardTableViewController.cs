/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class QuestRewardTableViewController : TableViewController<Gluon.QuestResultModel.FirstClearModel.FirstClearItemInfo>
	{
		// Fields
		[SerializeField]
		private int _maxCellCount;
		[SerializeField]
		protected Button closeButton;
		[SerializeField]
		protected UnityEngine.UI.Text uiTitle;
		[SerializeField]
		protected UnityEngine.UI.Text uiMainText;
		[SerializeField]
		protected DragEventScrollRect dragScrollRect;
		[SerializeField]
		protected Image _frame;
		[SerializeField]
		protected Vector3 centerPos;
		protected float cellHeight;
	
		// Properties
		public int maxCellCount { get; }
		public Image frame { get; }
	
		// Constructors
		public QuestRewardTableViewController();
	
		// Methods
		protected override void Start();
		protected virtual void LoadData();
		protected override float GetCellHeightAtIndex(int index);
		public virtual void SetRewardItemInfo(List<QuestResultModel.FirstClearModel.FirstClearItemInfo> rewardItemList);
		public void SetCloseButtonEvent(UnityAction action);
		public void SetText(string title, string mainText);
		public void DisableScroll();
		public void SetCellTopToCenter();
		public void SetCellCenterPositionY(float setPositionY);
	}
}
