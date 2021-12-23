using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeNextFloorConfirmDialog : InGameDialogBase
	{
		public class Param
		{
			public Action<Action> onClickInventoryButton;

			public Action<Action> onClickSkillButton;

			public Action onClickNextFloorButton;

			public Action onClickCancelButton;
		}

		[SerializeField]
		[Header("components")]
		private RectTransform headRt;

		[SerializeField]
		private RectTransform frameRt;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083\u008aã\u0082¦ã\u0083³ã\u0082¹ã\u0081®æ\u0098\u009fï¼\u0095ã\u0083\u0088ã\u0082°ã\u0083«")]
		private Toggle announceStar5Toggle;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083\u008aã\u0082¦ã\u0083³ã\u0082¹ã\u0081®æ\u0098\u009fï¼\u0094ã\u0083\u0088ã\u0082°ã\u0083«")]
		private Toggle announceStar4Toggle;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083\u008aã\u0082¦ã\u0083³ã\u0082¹ã\u0081®æ\u0098\u009fï¼\u0093ã\u0083\u0088ã\u0082°ã\u0083«")]
		private Toggle announceStar3Toggle;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083\u008aã\u0082¦ã\u0083³ã\u0082¹ã\u0081®ã\u0082¹ã\u0082­ã\u0083«ã\u0083\u0088ã\u0082°ã\u0083«")]
		private Toggle announceSkillToggle;

		[SerializeField]
		[Tooltip("ã\u0083\u0095ã\u0083­ã\u0082¢é\u0081·ç§»ã\u0083\u009cã\u0082¿ã\u0083³")]
		private Button nextFloorButton;

		[SerializeField]
		[Tooltip("ã\u0082­ã\u0083£ã\u0083³ã\u0082»ã\u0083«ã\u0083\u009cã\u0082¿ã\u0083³")]
		private Button cancelButton;

		public Param param;

		private RectTransform rootRt;

		public Action onClickNextFloorButtonExternal;

		public Action onClickCancelButtonExternal;

		public static DmodeNextFloorConfirmDialog Create(GameObject parent)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public void Open(Action onClickNextFloorButtonExternal, Action onClickCancelButtonExternal)
		{
		}

		public bool Close(bool isPlayCloseSE = false, [Optional] Action onCloseComplete)
		{
			return default(bool);
		}

		protected override void SetEnableButtons(bool b)
		{
		}

		public void OnInventoryButtonPressed()
		{
		}

		public bool ExecInventoryButtonPressed()
		{
			return default(bool);
		}

		public void OnSkillButtonPressed()
		{
		}

		public bool ExecSkillButtonPressed()
		{
			return default(bool);
		}

		public void OnNextFloorButtonPressed()
		{
		}

		private bool ExecNextFloorButtonPressed()
		{
			return default(bool);
		}

		public void OnCancelButtonPressed()
		{
		}

		public void OnClickAnnounceStar5(bool value)
		{
		}

		public void OnClickAnnounceStar4(bool value)
		{
		}

		public void OnClickAnnounceStar3(bool value)
		{
		}

		public void OnClickAnnounceSkill(bool value)
		{
		}
	}
}
