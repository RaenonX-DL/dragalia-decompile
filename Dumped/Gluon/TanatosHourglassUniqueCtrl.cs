namespace Gluon
{
	public class TanatosHourglassUniqueCtrl : EnemyUniqueCtrl
	{
		public enum State
		{
			Ignore,
			Floating,
			Drop
		}

		private bool _isActiveHourglass;

		private float _timer;

		private State _state;

		private TanatosUniqueCtrl _tanatosUniqCtrl;

		private float _floatingHeight;

		private float _moveCount;

		private const float CountDownInterval = 1f;

		public TanatosUniqueCtrl TanatosUniqCtrl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void Initialize()
		{
		}

		protected override void OnEnable()
		{
		}

		public override void FastUpdate()
		{
		}

		private void FloatingHourglassMove()
		{
		}

		private void ActiveHourglass(bool isActive)
		{
		}

		public void ChangeState(State state)
		{
		}
	}
}
