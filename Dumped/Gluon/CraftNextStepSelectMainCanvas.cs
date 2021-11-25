using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class CraftNextStepSelectMainCanvas : CraftEffectMainCanvas
	{
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
		private Text baseWeaponText;

		[SerializeField]
		private Text listFrameText;

		[SerializeField]
		private Text showListText;

		[SerializeField]
		private Text showTreeText;

		private CraftTreeDiagramData[] craftTreeDiagramDatas;

		private List<CraftTreeDiagramCell> treeDiagramIconCells;

		private CraftTreeDiagramData nowSelectData;

		protected override void Start()
		{
		}

		public void ChangeListView()
		{
		}

		public void UpdateListObj()
		{
		}

		public void SetupTreeDiagram(int groupId, CraftTreeDiagramData[] treeDiagramDatas)
		{
		}

		public void DeleteTreeUI()
		{
		}

		private int GetTreeClos(CraftTreeDiagramData data)
		{
			return default(int);
		}

		public CraftTreeDiagramData GetTreeDataByNodeId(int nodeId)
		{
			return null;
		}

		private bool IsExistChild(CraftTreeDiagramData data, int targetNodeId)
		{
			return default(bool);
		}

		public void OnTreeDiaglamCellPressed(int nodeId)
		{
		}

		public void OnCraftButtonPressed()
		{
		}

		public void TreeViewScrollCallBack()
		{
		}

		private void UpdateCraftButton(bool isCraftEnable)
		{
		}

		private void ResetSelectBadge()
		{
		}
	}
}
