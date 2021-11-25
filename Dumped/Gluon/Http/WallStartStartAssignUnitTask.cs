using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class WallStartStartAssignUnitTask : IHttpTask
	{
		private byte[] postData;

		private Action<WallStartStartAssignUnitResponse> onSuccess;

		private Action<ErrorType, int, WallStartStartAssignUnitResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public WallStartStartAssignUnitTask(WallStartStartAssignUnitRequest request, Action<WallStartStartAssignUnitResponse> onSuccess, Action<ErrorType, int, WallStartStartAssignUnitResponse> onError)
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
