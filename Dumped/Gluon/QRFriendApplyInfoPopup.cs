using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class QRFriendApplyInfoPopup : QuestResultCommonPopup
	{
		[SerializeField]
		public Transform cellTrans;

		[SerializeField]
		public GameObject cell;

		public static QRFriendApplyInfoPopup Create([Optional] Action onOK)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public override void OnOKOrClosePopup()
		{
		}
	}
}
