using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class AlbumIndexTask : IHttpTask
	{
		private byte[] postData;

		private Action<AlbumIndexResponse> onSuccess;

		private Action<ErrorType, int, AlbumIndexResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public AlbumIndexTask(AlbumIndexRequest request, Action<AlbumIndexResponse> onSuccess, Action<ErrorType, int, AlbumIndexResponse> onError)
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
