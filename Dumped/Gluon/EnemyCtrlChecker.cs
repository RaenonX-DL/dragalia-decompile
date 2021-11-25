namespace Gluon
{
	public class EnemyCtrlChecker
	{
		private bool _isEnabled;

		private bool _isInExecScript;

		private bool _didActionIdSet;

		private static readonly int CheckErrorThreshold;

		private float _checkErrorTimer;

		private int _enemyId;

		public EnemyCtrlChecker(int id)
		{
		}

		public void BeginExecScript()
		{
		}

		public void EndExecScript()
		{
		}

		public void NotifySetActionId()
		{
		}

		public void NotifySetupSoloAI()
		{
		}

		private void Error()
		{
		}
	}
}
