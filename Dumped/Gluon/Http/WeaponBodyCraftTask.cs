using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class WeaponBodyCraftTask : IHttpTask
	{
		private byte[] postData;

		private Action<WeaponBodyCraftResponse> onSuccess;

		private Action<ErrorType, int, WeaponBodyCraftResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public WeaponBodyCraftTask(WeaponBodyCraftRequest request, Action<WeaponBodyCraftResponse> onSuccess, Action<ErrorType, int, WeaponBodyCraftResponse> onError)
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
