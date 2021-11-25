using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class CharaSetCharaUnitSetTask : IHttpTask
	{
		private byte[] postData;

		private Action<CharaSetCharaUnitSetResponse> onSuccess;

		private Action<ErrorType, int, CharaSetCharaUnitSetResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public CharaSetCharaUnitSetTask(CharaSetCharaUnitSetRequest request, Action<CharaSetCharaUnitSetResponse> onSuccess, Action<ErrorType, int, CharaSetCharaUnitSetResponse> onError)
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
