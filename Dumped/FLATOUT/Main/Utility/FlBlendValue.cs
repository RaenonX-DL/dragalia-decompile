namespace FLATOUT.Main.Utility
{
	public class FlBlendValue : FlBlendBase
	{
		private float _startValue;

		private float _endValue;

		private float _currentValue;

		public float StartValue => default(float);

		public float EndValue => default(float);

		public float CurrentValue => default(float);

		public FlBlendValue(float startValue, float endValue, float blendTime, BlendTypes blendModeType)
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

		public virtual void SetStartValue(float startValue)
		{
		}

		public virtual void SetEndValue(float endValue)
		{
		}
	}
}
