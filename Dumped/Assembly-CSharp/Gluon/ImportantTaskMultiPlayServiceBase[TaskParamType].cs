/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public abstract class ImportantTaskMultiPlayServiceBase<TaskParamType>
	{
		// Fields
		private static int _nextTaskId;
		private List<TaskInfo> _reservedEventList;
		private List<int> _receivedEventList;
	
		// Nested types
		private class TaskInfo
		{
			// Fields
			public int taskId;
			public CharacterBase owner;
			public TaskParamType param;
	
			// Constructors
			public TaskInfo();
		}
	
		// Constructors
		protected ImportantTaskMultiPlayServiceBase();
	
		// Methods
		public static int CreateTaskId();
		public static void ResetTaskId();
		public void Update();
		protected void RequestTask(int taskId, CharacterBase owner, TaskParamType param);
		protected abstract void SendEvent(int taskId, TaskParamType summonEvent);
		protected abstract TaskParamType CloneParam(TaskParamType src);
		protected abstract void Execute(TaskParamType param);
		protected void OnReceiveEvent(int taskId, CharacterBase owner, TaskParamType param);
		private bool IsReserved(int taskId);
		private void ResetReserve(int taskId);
	}
}
