/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class MatchingGetRoomListByQuestIdTask : IHttpTask
	{
		// Fields
		private byte[] postData;
		private Action<MatchingGetRoomListByQuestIdResponse> onSuccess;
		private Action<ErrorType, int, MatchingGetRoomListByQuestIdResponse> onError;
		private Dictionary<string, string> headers;
		private IWebRequest request;
	
		// Properties
		public int CacheTime { get; }
		public bool IsEncrypt { get; }
	
		// Constructors
		public MatchingGetRoomListByQuestIdTask(MatchingGetRoomListByQuestIdRequest request, Action<MatchingGetRoomListByQuestIdResponse> onSuccess, Action<ErrorType, int, MatchingGetRoomListByQuestIdResponse> onError);
	
		// Methods
		public void SetHeader(string key, string value);
		public IWebRequest Send(string url);
		public bool Deserialize(byte[] body);
		public void OnError(ErrorType errorType, int resultCode);
	}
}
