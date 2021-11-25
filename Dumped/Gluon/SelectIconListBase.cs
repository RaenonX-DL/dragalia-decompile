using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class SelectIconListBase : CommonIconListBase
	{
		public UnityAction tabButtonCallBack;

		public Button decideButton;

		public TabBase tab;

		public RectTransform lockButtonBase;

		private void Start()
		{
		}

		public void ListTabPressedZeroToOne(int index)
		{
		}

		public void ListTabPressed(int tabTag)
		{
		}

		public void LockCharacterTab(bool interactable)
		{
		}

		private void CheckTutorial()
		{
		}
	}
}
