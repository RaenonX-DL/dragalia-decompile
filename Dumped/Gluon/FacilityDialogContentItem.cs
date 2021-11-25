using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FacilityDialogContentItem : MonoBehaviour
	{
		[SerializeField]
		protected Text titleLabel;

		[SerializeField]
		private Text valueLabel;

		[SerializeField]
		protected Text valueNextLevelLabel;

		[SerializeField]
		protected Color nextLevelColor;

		public void SetContent(string title, string value, string valueNextLevel = "", bool isValueUp = true)
		{
		}
	}
}
