using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultFriendApplyPage : MonoBehaviour
	{
		[SerializeField]
		[Header("Animation")]
		public Transform panelParent;

		public Transform rebattlePart;

		public GameObject rebattleGOToClose;

		public GameObject originalCell;

		public Transform contentParent;

		public Text rebattleCountDownText;

		private List<QRFriendApplyCell> createdCellList;

		private DateTime rebattleStartTime;

		private UnityAction onOpenUnitDetail;

		private UnityAction onCloseUnitDetail;

		private void Awake()
		{
		}

		public void InitByData()
		{
		}

		private void CreateFirstMetRewardDialog()
		{
		}

		private IEnumerator UpdateRebattle()
		{
			return null;
		}

		private void CloseRebattleWindow()
		{
		}

		public void OnRebattlePressed()
		{
		}

		public void OnRebattleCancelPressed()
		{
		}

		private void OnOpenDetail()
		{
		}

		private void OnCloseDetail()
		{
		}

		public void SetUnitDetailModelOnCreated(UnityAction action)
		{
		}

		public void SetUnitDetailModelBackButtonOnClick(UnityAction action)
		{
		}
	}
}
