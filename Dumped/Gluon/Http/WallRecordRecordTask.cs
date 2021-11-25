using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class WallRecordRecordTask : IHttpTask
	{
		private byte[] postData;

		private Action<WallRecordRecordResponse> onSuccess;

		private Action<ErrorType, int, WallRecordRecordResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public WallRecordRecordTask(WallRecordRecordRequest request, Action<WallRecordRecordResponse> onSuccess, Action<ErrorType, int, WallRecordRecordResponse> onError)
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
