using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class DmodeSkillSelectPopup : PopupBase
	{
		[SerializeField]
		[Header("TableViews")]
		public DmodeSkillSelectTableViewController controller;

		[SerializeField]
		[Header("TopPart")]
		public DmodeCommonInGameIcon iconTemplate;

		public static readonly string prefabPath;

		private Action<List<int>> onEditDone;

		private Action onClose;

		private List<DmodeCommonInGameIcon> icons;

		public int selectingBottomIndex;

		public List<int> selectedIds
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

		public int selectingTopIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static DmodeSkillSelectPopup Create(List<int> selectedIds, Action<List<int>> onEditDone, [Optional] Action onClose)
		{
			return null;
		}

		protected override void Start()
		{
		}

		private void UpdateTopPartView()
		{
		}

		public void OnTopItemSelect(DmodeDungeonItemType type, int index)
		{
		}

		public void OnBottomItemSelect(int data)
		{
		}

		public void OnItemSelected(int index, bool fromTop)
		{
		}

		public void OnOKButtonPressed()
		{
		}

		private void OnClose()
		{
		}
	}
}
