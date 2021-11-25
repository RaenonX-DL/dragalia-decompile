using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class PlatformAchievementGetPlatformAchievementListTask : IHttpTask
	{
		private byte[] postData;

		private Action<PlatformAchievementGetPlatformAchievementListResponse> onSuccess;

		private Action<ErrorType, int, PlatformAchievementGetPlatformAchievementListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public PlatformAchievementGetPlatformAchievementListTask(PlatformAchievementGetPlatformAchievementListRequest request, Action<PlatformAchievementGetPlatformAchievementListResponse> onSuccess, Action<ErrorType, int, PlatformAchievementGetPlatformAchievementListResponse> onError)
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
