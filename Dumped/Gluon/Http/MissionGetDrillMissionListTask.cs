using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MissionGetDrillMissionListTask : IHttpTask
	{
		private byte[] postData;

		private Action<MissionGetDrillMissionListResponse> onSuccess;

		private Action<ErrorType, int, MissionGetDrillMissionListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MissionGetDrillMissionListTask(MissionGetDrillMissionListRequest request, Action<MissionGetDrillMissionListResponse> onSuccess, Action<ErrorType, int, MissionGetDrillMissionListResponse> onError)
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
