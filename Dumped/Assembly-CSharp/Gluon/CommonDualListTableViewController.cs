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
	public class CommonDualListTableViewController : CommonIconListController
	{
		// Fields
		[Header]
		protected int iconListLine;
		protected RectOffset iconListPadding;
		protected Vector2 iocnListSpacing;
		protected GameObject iconOriginalCell;
		protected Vector2 iconCellSize;
		[Header]
		[SerializeField]
		protected int cellListLine;
		[SerializeField]
		protected RectOffset cellListPadding;
		[SerializeField]
		protected Vector2 cellListSpacing;
		private GameObject[] listOriginalCells;
		[SerializeField]
		protected UnityEngine.UI.Text changeListText;
		public bool isShowIconList;
	
		// Properties
		public int tableCount { get; }
	
		// Constructors
		public CommonDualListTableViewController();
	
		// Methods
		protected override void Awake();
		public virtual void ReloadIconListLayout(CommonDualListType listType = CommonDualListType.Amulet);
		public void SetListChangeButtonText(CommonDualListType type);
		public void ReloadInfoListLayout(CommonDualListType type);
		public virtual void OnListTypeReloaded();
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		private GameObject GetOriginCellObject(CommonDualListType type);
	}
}
