using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlBlendVector : FlBlendBase
	{
		private Vector3 _startValue;

		private Vector3 _endValue;

		private Vector3 _currentValue;

		public Vector3 StartValue => default(Vector3);

		public Vector3 EndValue => default(Vector3);

		public Vector3 CurrentValue => default(Vector3);

		public FlBlendVector(Vector3 startValue, Vector3 endValue, float blendTime, BlendTypes blendModeType)
		{
		}

		public override void Reset()
		{
		}

		public override void Update(float deltaTime)
		{
		}

		private void UpdateCurrentValue()
		{
		}

		public virtual void SetStartValue(Vector3 startValue)
		{
		}

		public virtual void SetEndValue(Vector3 endValue)
		{
		}
	}
}
