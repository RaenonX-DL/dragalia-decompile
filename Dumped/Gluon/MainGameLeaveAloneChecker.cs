using Gluon.Master;

namespace Gluon
{
	public class MainGameLeaveAloneChecker
	{
		private bool _isRequestLeaveAlone;

		private CommonDialog _leaveAloneDialog;

		private CommonDialog.Param _leaveAloneDialogParam;

		private float _warnningTime;

		private float _exitTime;

		public const float LEAVE_ALONE_WARNNING_TIME = 20f;

		public const float LEAVE_ALONE_EXIT_TIME = 30f;

		public const float LEAVE_ALONE_WARNNING_OFFSET_TIME = 10f;

		public bool isRequestLeaveAlone => default(bool);

		public void SetLeaveAloneTime(QuestDataElement qde)
		{
		}

		public void CheckLeaveAlone()
		{
		}

		private bool IsPauseLeaveAloneTime()
		{
			return default(bool);
		}

		private void ResetLeaveAloneTime()
		{
		}
	}
}
