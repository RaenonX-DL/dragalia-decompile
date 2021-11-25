using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MissionGetMissionListTask : IHttpTask
	{
		private byte[] postData;

		private Action<MissionGetMissionListResponse> onSuccess;

		private Action<ErrorType, int, MissionGetMissionListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MissionGetMissionListTask(MissionGetMissionListRequest request, Action<MissionGetMissionListResponse> onSuccess, Action<ErrorType, int, MissionGetMissionListResponse> onError)
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
