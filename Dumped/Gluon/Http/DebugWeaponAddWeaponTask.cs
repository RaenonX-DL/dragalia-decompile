using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugWeaponAddWeaponTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugWeaponAddWeaponResponse> onSuccess;

		private Action<ErrorType, int, DebugWeaponAddWeaponResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugWeaponAddWeaponTask(DebugWeaponAddWeaponRequest request, Action<DebugWeaponAddWeaponResponse> onSuccess, Action<ErrorType, int, DebugWeaponAddWeaponResponse> onError)
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
