using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FortBuildGaugeController : MonoBehaviour
	{
		public delegate void GaugeChangeDelegate();

		[SerializeField]
		private Text text;

		[SerializeField]
		public Slider slider;

		private Image[] images;

		private StringBuilder strBuilder;

		private void Awake()
		{
		}

		public void Disp(bool flag)
		{
		}

		public void SetRestTime(Facility facility)
		{
		}

		public void SetMaxIncomeRestTime(FacilityViewController facilityVC)
		{
		}
	}
}
