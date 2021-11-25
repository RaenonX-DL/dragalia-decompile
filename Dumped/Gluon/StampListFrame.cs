using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class StampListFrame : MonoBehaviour
	{
		public UnityAction<int> listButtonCallBack;

		public UnityAction<int> listLongPressCallBack;

		public StampSetData nowStampSet;

		public Button saveButton;

		[SerializeField]
		private Text title;

		[SerializeField]
		private Text stampNum;

		[SerializeField]
		private Text stampNumValue;

		[SerializeField]
		private StampListController _stampListCtrl;

		public StampListController stampListCtrl => null;

		public void SetTitle(Localize.TextId id)
		{
		}

		public void SetNum(int num)
		{
		}
	}
}
