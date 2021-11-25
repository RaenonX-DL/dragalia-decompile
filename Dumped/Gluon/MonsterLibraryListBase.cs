using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class MonsterLibraryListBase : MonoBehaviour
	{
		public UnityAction sortButtonAction;

		public UnityAction<int> IconButtonAction;

		[SerializeField]
		private Text ListDataText;

		public void SetListData(int found, int complete)
		{
		}

		public void SortButtonPressed()
		{
		}
	}
}
