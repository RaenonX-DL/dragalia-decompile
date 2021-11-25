using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class CharaGetListTask : IHttpTask
	{
		private byte[] postData;

		private Action<CharaGetListResponse> onSuccess;

		private Action<ErrorType, int, CharaGetListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public CharaGetListTask(CharaGetListRequest request, Action<CharaGetListResponse> onSuccess, Action<ErrorType, int, CharaGetListResponse> onError)
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
