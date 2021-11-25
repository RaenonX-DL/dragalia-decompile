using UnityEngine;

namespace Gluon
{
	public class ColorStyle : MaterialControlComponent
	{
		private const string _colorPropetyName = "_Color";

		private const string _colorPowerPropetyName = "_ColorPower";

		[SerializeField]
		private Gradient _gradient;

		[SerializeField]
		private AnimationCurve _ColorPowerCurve;

		[SerializeField]
		private float _animationTotalTime;

		[SerializeField]
		private float _animationStartOffsetTime;

		[SerializeField]
		private bool _isLoop;

		private int _colorPoropetyID;

		private int _colorPowerPoropetyID;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
