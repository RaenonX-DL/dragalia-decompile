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
	public class QuestCommonTableViewController<T> : TableViewController<T>
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text _tableViewTitle;
		private QuestSelectScene.Difficulty _difficulty;
		[CompilerGenerated]
		private QuestCommonTableViewData _curViewData_k__BackingField;
		protected AnimationListOneCol animationListOneCol;
	
		// Properties
		public QuestSelectScene.Difficulty difficulty { get; set; }
		public UnityEngine.UI.Text tableViewTitle { get; }
		public QuestCommonTableViewData curViewData { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public QuestCommonTableViewController();
	
		// Methods
		protected override void Awake();
		protected override void Start();
		public virtual void LoadData();
		public int GetTableDataCount();
		public T GetTableDataByIndex(int index);
		public void SetAlphaToCellsList(float alpha);
		public void OnOpen(float eachWaitTime);
		public void OnClose();
		protected void SetupAnimationCell(TableViewCell<T> cell, int index);
		protected void ClearAnimationCells();
		public bool IsOnAnimation();
	}
}
