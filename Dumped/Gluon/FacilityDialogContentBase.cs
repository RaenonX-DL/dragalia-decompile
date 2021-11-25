using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FacilityDialogContentBase : MonoBehaviour
	{
		[SerializeField]
		private Image icon;

		[SerializeField]
		private Text title;

		[SerializeField]
		private Text level;

		[SerializeField]
		private Text afterLevel;

		[SerializeField]
		private Text description;

		[SerializeField]
		private float offsetY;

		public void SetContent(Facility facility, [Optional] Facility nextFacility)
		{
		}

		public void SetContent(Facility facility, string titleStr, int levelValue, string descriptionStr)
		{
		}
	}
}
