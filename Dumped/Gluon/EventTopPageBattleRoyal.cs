using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventTopPageBattleRoyal : EventTopPageBase
	{
		[SerializeField]
		[Header("BattleRoyal Buttons")]
		protected Button enterBattleButton;

		[SerializeField]
		protected Button selectSkinButton;

		[SerializeField]
		protected Button recordButton;

		[SerializeField]
		protected Button pickupButton;

		[SerializeField]
		[Header("Lock")]
		protected GameObject lockButton;

		[SerializeField]
		protected Color disabledColor;

		private bool isAvailable;

		private DateTime startDT;

		private DateTime endDT;

		protected override void SetDurationText()
		{
		}

		protected override void Start()
		{
		}

		public void OnLockButtonPressed()
		{
		}

		public void OnEnterBattleButtonPressed()
		{
		}

		public void OnSelectSkinButtonPressed()
		{
		}

		public void OnRecordButtonPressed()
		{
		}

		public void OnPickupButtonPressed()
		{
		}

		private int[] GetSpecialSkillPickupCharaSkinIds()
		{
			return null;
		}
	}
}
