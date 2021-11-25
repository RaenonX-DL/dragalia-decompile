using System;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class PartyCrestSetPopup : CommonPopup
	{
		public const int maxSetCountInGroup = 6;

		public TabBase setGroupTab;

		public Transform listParentTransform;

		public GameObject originCell;

		public Action<int> selectCrestSetCallBack;

		private PartyCrestSetPopupCell[] cells;

		private int selectGroupIndex;

		public static PartyCrestSetPopup Create()
		{
			return null;
		}

		public void InitPopup()
		{
		}

		public override void StartShowAnimation([Optional] UnityEvent onCompleted)
		{
		}

		private void OnSelectedGroupTab(int index)
		{
		}

		private void ReloadCell()
		{
		}

		private void SendRegistData(int setIndex)
		{
		}

		private bool CanRegistCrestSetData()
		{
			return default(bool);
		}

		private AtgenRequestAbilityCrestSetData CreateRegistData(int setIndex)
		{
			return null;
		}

		private void SelectCrestSet(int setIndex)
		{
		}
	}
}
