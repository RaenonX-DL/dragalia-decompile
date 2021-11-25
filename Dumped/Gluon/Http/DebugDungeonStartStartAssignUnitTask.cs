using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugDungeonStartStartAssignUnitTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugDungeonStartStartAssignUnitResponse> onSuccess;

		private Action<ErrorType, int, DebugDungeonStartStartAssignUnitResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugDungeonStartStartAssignUnitTask(DebugDungeonStartStartAssignUnitRequest request, Action<DebugDungeonStartStartAssignUnitResponse> onSuccess, Action<ErrorType, int, DebugDungeonStartStartAssignUnitResponse> onError)
		{
		}

		public void SetHeader(string key, string value)
		{
		}

		public IWebRequest Send(string url)
		{
			return null;
		}

		public bool Deserialize(byte[] body)
		{
			return default(bool);
		}

		public void OnError(ErrorType errorType, int resultCode)
		{
		}
	}
}
