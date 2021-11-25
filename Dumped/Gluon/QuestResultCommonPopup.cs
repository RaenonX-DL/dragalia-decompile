using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class QuestResultCommonPopup : CommonPopup
	{
		[SerializeField]
		[Header("ExitUIPublisher")]
		protected AnimationUIAutoPublisher exitUIPublisher;

		protected Action onOKOrClose;

		protected Action onCancel;

		public static QuestResultCommonPopup Create(string title, string text, BottomButtons bottomButtons = BottomButtons.Close, [Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
			return null;
		}

		public static QuestResultCommonPopup CreateWithPrefab(string prefabName, [Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
			return null;
		}

		public void SetCallbacks([Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
		}

		private void InitWithTitleAndText(string title, string text, [Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
		}

		protected override void Start()
		{
		}

		public virtual void OnOKOrClosePopup()
		{
		}

		public virtual void OnOKOrClosePopupWithSlideAnim()
		{
		}

		public virtual void OnCancelPopup()
		{
		}
	}
}
