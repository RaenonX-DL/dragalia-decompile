using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MypageInfoTask : IHttpTask
	{
		private byte[] postData;

		private Action<MypageInfoResponse> onSuccess;

		private Action<ErrorType, int, MypageInfoResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MypageInfoTask(MypageInfoRequest request, Action<MypageInfoResponse> onSuccess, Action<ErrorType, int, MypageInfoResponse> onError)
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
