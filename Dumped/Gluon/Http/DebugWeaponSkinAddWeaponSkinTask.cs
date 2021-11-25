using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugWeaponSkinAddWeaponSkinTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugWeaponSkinAddWeaponSkinResponse> onSuccess;

		private Action<ErrorType, int, DebugWeaponSkinAddWeaponSkinResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugWeaponSkinAddWeaponSkinTask(DebugWeaponSkinAddWeaponSkinRequest request, Action<DebugWeaponSkinAddWeaponSkinResponse> onSuccess, Action<ErrorType, int, DebugWeaponSkinAddWeaponSkinResponse> onError)
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
