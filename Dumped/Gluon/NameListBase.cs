using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class NameListBase : MonoBehaviour
	{
		public Text nameCount;

		public CommonSortButton sortButton;

		public UnityAction<AnotherNameCellData> listButtonCallBack;

		public Text emptySortDataText;

		public AnotherNameListController anotherNameListController;

		public UnityAction sortButtonCallBack;

		private void Start()
		{
		}
	}
}
