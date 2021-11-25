using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonDualListTableViewController : CommonIconListController
	{
		[Header("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0083ªã\u0082¹ã\u0083\u0088é\u0096¢é\u0080£")]
		protected int iconListLine;

		protected RectOffset iconListPadding;

		protected Vector2 iocnListSpacing;

		protected GameObject iconOriginalCell;

		protected Vector2 iconCellSize;

		[SerializeField]
		[Header("ã\u0083ªã\u0082¹ã\u0083\u0088è¡\u00a8ç¤ºé\u0096¢é\u0080£")]
		protected int cellListLine;

		[SerializeField]
		protected RectOffset cellListPadding;

		[SerializeField]
		protected Vector2 cellListSpacing;

		private GameObject[] listOriginalCells;

		[SerializeField]
		protected Text changeListText;

		[SerializeField]
		protected CommonTagSearch tagSearch;

		protected List<CommonIconListCellData> originalTableData;

		private bool preventOnModelChanged;

		private bool preventNextClearText;

		private Coroutine inputFilterChangedCoroutine;

		private int oldFilterIdCount;

		public bool isShowIconList;

		public bool isSkipListReloadDelay;

		public ulong[] originalKeyIdList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int tableCount => default(int);

		protected override void Awake()
		{
		}

		public virtual void ReloadIconListLayout(CommonDualListType listType = CommonDualListType.Amulet)
		{
		}

		public void SetListChangeButtonText(CommonDualListType type)
		{
		}

		public void ReloadInfoListLayout(CommonDualListType type)
		{
		}

		public virtual void OnListTypeReloaded()
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		protected override float GetCellWidthAtIndex(int index)
		{
			return default(float);
		}

		private GameObject GetOriginCellObject(CommonDualListType type)
		{
			return null;
		}

		protected void OnModelChangedForInputFilter()
		{
		}

		private void OnInputFilterChanged(List<int> filteredId)
		{
		}

		private IEnumerator UpdateSerchTargetList(List<int> filteredId)
		{
			return null;
		}

		private void ClearInputFilter()
		{
		}

		protected void UpdateSearchInputFilter()
		{
		}
	}
}
