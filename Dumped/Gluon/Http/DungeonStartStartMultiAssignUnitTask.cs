using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DungeonStartStartMultiAssignUnitTask : IHttpTask
	{
		private byte[] postData;

		private Action<DungeonStartStartMultiAssignUnitResponse> onSuccess;

		private Action<ErrorType, int, DungeonStartStartMultiAssignUnitResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DungeonStartStartMultiAssignUnitTask(DungeonStartStartMultiAssignUnitRequest request, Action<DungeonStartStartMultiAssignUnitResponse> onSuccess, Action<ErrorType, int, DungeonStartStartMultiAssignUnitResponse> onError)
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
