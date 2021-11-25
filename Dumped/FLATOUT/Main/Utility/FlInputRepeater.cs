namespace FLATOUT.Main.Utility
{
	public class FlInputRepeater
	{
		public enum RepeaterStateTypes
		{
			Wait_Init,
			Wait_Loop,
			First_Init,
			First_Loop,
			Second_Init,
			Second_Loop
		}

		private RepeaterStateTypes _currentState;

		private float _currentRepeatTime;

		private bool _repeatStartFlag;

		private bool _repeatOn;

		private void _Update_Common_Start()
		{
		}

		public void _Update()
		{
		}

		private void _Update_Common_End()
		{
		}

		private void _Update_Wait_Init()
		{
		}

		private void _Update_Wait_Loop()
		{
		}

		private void _Update_First_Init()
		{
		}

		private void _Update_First_Loop()
		{
		}

		private void _Update_Second_Init()
		{
		}

		private void _Update_Second_Loop()
		{
		}

		public bool GetRepeat()
		{
			return default(bool);
		}

		public void Start()
		{
		}

		public void End()
		{
		}
	}
}
