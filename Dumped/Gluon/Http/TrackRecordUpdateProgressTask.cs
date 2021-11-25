using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class TrackRecordUpdateProgressTask : IHttpTask
	{
		private byte[] postData;

		private Action<TrackRecordUpdateProgressResponse> onSuccess;

		private Action<ErrorType, int, TrackRecordUpdateProgressResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public TrackRecordUpdateProgressTask(TrackRecordUpdateProgressRequest request, Action<TrackRecordUpdateProgressResponse> onSuccess, Action<ErrorType, int, TrackRecordUpdateProgressResponse> onError)
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
