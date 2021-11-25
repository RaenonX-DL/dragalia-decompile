namespace FLATOUT.Main.Utility
{
	public class FlBlendIntValue : FlBlendBase
	{
		private int _startValue;

		private int _endValue;

		private int _currentValue;

		public int StartValue => default(int);

		public int EndValue => default(int);

		public int CurrentValue => default(int);

		public FlBlendIntValue(int startValue, int endValue, float blendTime, BlendTypes blendModeType)
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

		public virtual void SetStartValue(int startValue)
		{
		}

		public virtual void SetEndValue(int endValue)
		{
		}
	}
}
