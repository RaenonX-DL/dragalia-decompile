using System;

namespace Gluon
{
	public class TutorialSummonPageBase : PageBase
	{
		public static readonly float NEXT_SUMMON_DELAY_START_TIME;

		public static readonly float NEXT_SUMMON_DELAY_END_TIME;

		public static readonly float NEXT_SUMMON_DELAY_ALLUNIT_POPUP_TIME;

		public static readonly float NEXT_SUMMON_DELAY_ALLUNIT_POPUP_AFTER_TIME;

		public TutorialSummonScene tutorialSummonScene => null;

		public void RequestTutorialStep(Action onComplete)
		{
		}

		public void RequestRedoableSummonGetData(Action onComplete)
		{
		}

		public void RequestRedoableSummonPreExec(Action onComplete)
		{
		}

		public void RequestRedoableSummonFixExec(Action onComplete)
		{
		}

		public void UnloadSummonBgScene()
		{
		}
	}
}
