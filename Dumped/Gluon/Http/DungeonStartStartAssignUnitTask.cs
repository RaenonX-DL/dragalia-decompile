using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DungeonStartStartAssignUnitTask : IHttpTask
	{
		private byte[] postData;

		private Action<DungeonStartStartAssignUnitResponse> onSuccess;

		private Action<ErrorType, int, DungeonStartStartAssignUnitResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DungeonStartStartAssignUnitTask(DungeonStartStartAssignUnitRequest request, Action<DungeonStartStartAssignUnitResponse> onSuccess, Action<ErrorType, int, DungeonStartStartAssignUnitResponse> onError)
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
