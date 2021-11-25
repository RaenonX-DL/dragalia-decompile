using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonSortButton : MonoBehaviour
	{
		[SerializeField]
		public Text filterOnOffText;

		public Text sortTypeText;

		public GameObject upwardImageGO;

		public GameObject downwardImageGO;

		public GameObject filterLineGO;

		public GameObject sortLineGO;

		public UnityEvent onButtonPressed;

		[SerializeField]
		private Transform filterColonTransform;

		[SerializeField]
		private Transform sortColonTransform;

		public void OnButtonPressed()
		{
		}

		public void DisableFilter()
		{
		}

		public void DisableSort()
		{
		}

		public void SetSortButtonDisplayText(bool isFilterOn, string orderText, bool isAscending)
		{
		}

		public void UpdateSortColonText()
		{
		}
	}
}
