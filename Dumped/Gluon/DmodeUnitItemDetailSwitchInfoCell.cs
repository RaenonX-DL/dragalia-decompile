using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeUnitItemDetailSwitchInfoCell : DmodeUnitItemDetailInfoCell
	{
		[SerializeField]
		[Header("Control")]
		protected GameObject normalPanel;

		[SerializeField]
		protected GameObject emptyPanel;

		[SerializeField]
		protected GameObject activeFrame;

		[SerializeField]
		protected GameObject nonActiveFrame;

		[SerializeField]
		protected Button button;

		private Action<int> onPressed;

		private int index;

		private int hp;

		private int atk;

		public void Setup(int id, int index = -1, [Optional] Action<int> onPressed)
		{
		}

		public void SetupWithDefaultWeapon()
		{
		}

		public void UpdateView(int compareHp, int compareAtk)
		{
		}

		public void OnPressed()
		{
		}

		public void SetSelectState(bool v)
		{
		}
	}
}
