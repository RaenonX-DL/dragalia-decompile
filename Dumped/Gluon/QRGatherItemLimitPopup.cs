using System;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QRGatherItemLimitPopup : PopupBase
	{
		[SerializeField]
		public CommonIcon icon;

		public Text titleText;

		public Text commentText;

		private int id;

		private string itemName;

		private int lastResetTime;

		private Action onDone;

		private const string prefabPath = "Prefabs/OutGame/QuestResult/Popup/QRGatherItemLimitPopup";

		private const string prefGatherItemLimitTemplate = "__QRGatherItem_{0}";

		public static UniTask ShowGatherItemLimitPopupIfNeeded()
		{
			return default(UniTask);
		}

		public static QRGatherItemLimitPopup Create(int id, string name, int lastResetTime, Action onDone)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnCloseButtonPressed()
		{
		}
	}
}
