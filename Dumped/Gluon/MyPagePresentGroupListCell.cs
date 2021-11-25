using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MyPagePresentGroupListCell : TableViewCell<MyPagePresentGroupListCellData>
	{
		[SerializeField]
		private Image cellButtonImage;

		[SerializeField]
		private CanvasGroup cellButtonGroup;

		[SerializeField]
		private Text groupNameText;

		[SerializeField]
		private Text quantityText;

		[SerializeField]
		private GameObject linkArrow;

		[SerializeField]
		private GameObject sceneButtonArea;

		[SerializeField]
		private Text duplicateConfirmText;

		[SerializeField]
		private Button sceneButtonLeft;

		[SerializeField]
		private Button sceneButtonCenter;

		[SerializeField]
		private Button sceneButtonRight;

		[SerializeField]
		private Text sceneButtonTextLeft;

		[SerializeField]
		private Text sceneButtonTextCenter;

		[SerializeField]
		private Text sceneButtonTextRight;

		private MyPagePresentGroupListCellData cellData;

		private GameObject lockObjLeft;

		private GameObject lockObjCenter;

		private GameObject lockObjRight;

		public override void UpdateContent(MyPagePresentGroupListCellData data)
		{
		}

		public void OnCellButtonPressed()
		{
		}

		public void OnSceneButtonPressed(int index)
		{
		}

		private void SetLockButtonWithStepCheck(Button button, TutorialUIManager.LockButtonType lockType, ref GameObject lockObj)
		{
		}
	}
}
