using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class WeaponSellTask : IHttpTask
	{
		private byte[] postData;

		private Action<WeaponSellResponse> onSuccess;

		private Action<ErrorType, int, WeaponSellResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public WeaponSellTask(WeaponSellRequest request, Action<WeaponSellResponse> onSuccess, Action<ErrorType, int, WeaponSellResponse> onError)
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
