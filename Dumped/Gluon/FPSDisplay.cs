using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FPSDisplay : MonoBehaviour
	{
		public float updateInterval;

		private float accum;

		private int frames;

		private float timeleft;

		private Text _text;

		private StringBuilder _stringBuilder;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
