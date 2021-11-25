using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine.UI;

namespace Gluon
{
	public class ContactSlider : FastUpdateMonoBehaviour
	{
		public Slider slider;

		public float stepValue;

		private float _currentValue;

		public float toValue
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float currentValue
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public override void FastUpdate()
		{
		}
	}
}
