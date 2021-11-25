using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugWeaponSkinAddAllTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugWeaponSkinAddAllResponse> onSuccess;

		private Action<ErrorType, int, DebugWeaponSkinAddAllResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugWeaponSkinAddAllTask(DebugWeaponSkinAddAllRequest request, Action<DebugWeaponSkinAddAllResponse> onSuccess, Action<ErrorType, int, DebugWeaponSkinAddAllResponse> onError)
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
