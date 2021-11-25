using System;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class FriendTopView : FriendPanelBase
	{
		private static Action onHttpDone;

		[SerializeField]
		private Badge friendListBadge;

		[SerializeField]
		private Badge approvalWaitBadge;

		public static FriendTopView Create(Transform parent, FriendScene scene)
		{
			return null;
		}

		private void Start()
		{
		}

		public static void RequestForEntryHttp(Action onHttpDoneCallback)
		{
		}

		public static void OnEntryHttpSuccess(FriendFriendIndexResponse response)
		{
		}
	}
}
