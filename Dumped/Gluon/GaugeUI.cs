using UnityEngine;

namespace Gluon
{
	public class GaugeUI : MonoBehaviour
	{
		[SerializeField]
		private GaugeSlicedUI gaugeFrame;

		[SerializeField]
		private GaugeSlicedUI gaugeDiff;

		[SerializeField]
		private GaugeSlicedUI gaugeCurrent;

		[SerializeField]
		private GaugeSlicedUI gaugeDanger;

		public void Initialize()
		{
		}

		public void SetValue(float v)
		{
		}
	}
}
