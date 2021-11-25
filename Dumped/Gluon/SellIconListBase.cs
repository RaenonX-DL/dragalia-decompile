using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class SellIconListBase : CommonIconListBase
	{
		public UnityAction tabButtonCallBack;

		public UnityAction sellModeButtonCallBack;

		public UnityAction listChangeButtonCallBack;

		public Button sellModeButton;

		public TabBase tab;

		public RectTransform lockButtonBase;

		public GameObject searchSpaceObject;

		[SerializeField]
		private GameObject listButtonObj;

		private void Start()
		{
		}

		private void SetModeText()
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

		public void SellChangeButtonPressed()
		{
		}

		private void CheckTutorial()
		{
		}

		public void OnListChangeButtonPressed()
		{
		}
	}
}
