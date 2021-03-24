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
	public class CraftNextStepSelectMainCanvas : CraftEffectMainCanvas
	{
		// Fields
		public CraftNextStepSelectListController nextStepSelectListController;
		public CraftEvolutionBaseFrame baseInfoFrame;
		public GameObject[] nextStepViewObj;
		public GameObject[] treeDiagramViewObj;
		public bool isShowTreeDiagram;
		public CraftTreeDiagramCell originCell;
		public CraftTreeDiagramArrowCell arrowOriginCell;
		public Transform treeListTransform;
		public Transform treeArrowListTransform;
		public UnityAction<int, bool, bool> craftButtonPressCallBack;
		public UnityAction changeButtonPressCallBack;
		public Button craftButton;
		public Sprite craftNormalSprite;
		public Sprite craftBlueSprite;
		[SerializeField]
		private UnityEngine.UI.Text baseWeaponText;
		[SerializeField]
		private UnityEngine.UI.Text listFrameText;
		[SerializeField]
		private UnityEngine.UI.Text showListText;
		[SerializeField]
		private UnityEngine.UI.Text showTreeText;
		private CraftTreeDiagramData[] craftTreeDiagramDatas;
		private List<CraftTreeDiagramCell> treeDiagramIconCells;
		private CraftTreeDiagramData nowSelectData;
	
		// Constructors
		public CraftNextStepSelectMainCanvas();
	
		// Methods
		protected override void Start();
		public void ChangeListView();
		public void UpdateListObj();
		public void SetupTreeDiagram(int groupId, CraftTreeDiagramData[] treeDiagramDatas);
		public void DeleteTreeUI();
		private int GetTreeClos(CraftTreeDiagramData data);
		public CraftTreeDiagramData GetTreeDataByNodeId(int nodeId);
		private bool IsExistChild(CraftTreeDiagramData data, int targetNodeId);
		public void OnTreeDiaglamCellPressed(int nodeId);
		public void OnCraftButtonPressed();
		public void TreeViewScrollCallBack();
		private void UpdateCraftButton(bool isCraftEnable);
		private void ResetSelectBadge();
	}
}
