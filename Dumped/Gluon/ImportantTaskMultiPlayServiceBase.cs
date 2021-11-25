using System.Collections.Generic;

namespace Gluon
{
	public abstract class ImportantTaskMultiPlayServiceBase<TaskParamType>
	{
		private class TaskInfo
		{
			public int taskId;

			public CharacterBase owner;

			public TaskParamType param;
		}

		private static int _nextTaskId;

		private List<TaskInfo> _reservedEventList;

		private List<int> _receivedEventList;

		public static int CreateTaskId()
		{
			return default(int);
		}

		public static void ResetTaskId()
		{
		}

		public void Update()
		{
		}

		protected void RequestTask(int taskId, CharacterBase owner, TaskParamType param)
		{
		}

		protected abstract void SendEvent(int taskId, TaskParamType summonEvent);

		protected abstract TaskParamType CloneParam(TaskParamType src);

		protected abstract void Execute(TaskParamType param);

		protected abstract void OnReserved(TaskParamType param);

		protected abstract void OnResetReserve(TaskParamType param);

		protected void OnReceiveEvent(int taskId, CharacterBase owner, TaskParamType param)
		{
		}

		private bool IsReserved(int taskId)
		{
			return default(bool);
		}

		private void ResetReserve(int taskId)
		{
		}
	}
}
