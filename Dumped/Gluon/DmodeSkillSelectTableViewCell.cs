using System;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class DmodeSkillSelectTableViewCell : TableViewCell<int>
	{
		[Serializable]
		public class ButtonEvent : UnityEvent<int>
		{
		}

		[SerializeField]
		[Header("Info")]
		public DmodeCommonInGameIcon icon;

		public ButtonEvent onCellPressed;

		[SerializeField]
		[Header("Selected")]
		public GameObject nowSelectingFrame;

		public GameObject selectedFrame;

		public DmodeSkillSelectPopup popup;

		protected override void Awake()
		{
		}

		public override void UpdateContent(int data)
		{
		}

		public void OnIconPressed(DmodeDungeonItemType type, int id)
		{
		}
	}
}
