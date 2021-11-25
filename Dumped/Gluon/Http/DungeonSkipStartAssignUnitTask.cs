using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DungeonSkipStartAssignUnitTask : IHttpTask
	{
		private byte[] postData;

		private Action<DungeonSkipStartAssignUnitResponse> onSuccess;

		private Action<ErrorType, int, DungeonSkipStartAssignUnitResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DungeonSkipStartAssignUnitTask(DungeonSkipStartAssignUnitRequest request, Action<DungeonSkipStartAssignUnitResponse> onSuccess, Action<ErrorType, int, DungeonSkipStartAssignUnitResponse> onError)
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
