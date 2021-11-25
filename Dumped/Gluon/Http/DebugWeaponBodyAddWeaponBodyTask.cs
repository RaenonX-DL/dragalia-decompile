using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugWeaponBodyAddWeaponBodyTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugWeaponBodyAddWeaponBodyResponse> onSuccess;

		private Action<ErrorType, int, DebugWeaponBodyAddWeaponBodyResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugWeaponBodyAddWeaponBodyTask(DebugWeaponBodyAddWeaponBodyRequest request, Action<DebugWeaponBodyAddWeaponBodyResponse> onSuccess, Action<ErrorType, int, DebugWeaponBodyAddWeaponBodyResponse> onError)
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
