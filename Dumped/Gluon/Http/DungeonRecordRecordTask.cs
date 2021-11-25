using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DungeonRecordRecordTask : IHttpTask
	{
		private byte[] postData;

		private Action<DungeonRecordRecordResponse> onSuccess;

		private Action<ErrorType, int, DungeonRecordRecordResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DungeonRecordRecordTask(DungeonRecordRecordRequest request, Action<DungeonRecordRecordResponse> onSuccess, Action<ErrorType, int, DungeonRecordRecordResponse> onError)
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
