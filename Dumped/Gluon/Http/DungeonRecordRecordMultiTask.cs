using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DungeonRecordRecordMultiTask : IHttpTask
	{
		private byte[] postData;

		private Action<DungeonRecordRecordMultiResponse> onSuccess;

		private Action<ErrorType, int, DungeonRecordRecordMultiResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DungeonRecordRecordMultiTask(DungeonRecordRecordMultiRequest request, Action<DungeonRecordRecordMultiResponse> onSuccess, Action<ErrorType, int, DungeonRecordRecordMultiResponse> onError)
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
