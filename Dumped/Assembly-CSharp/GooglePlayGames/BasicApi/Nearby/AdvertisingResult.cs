/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.Nearby
{
	public struct AdvertisingResult
	{
		// Fields
		private readonly ResponseStatus mStatus;
		private readonly string mLocalEndpointName;
	
		// Properties
		public bool Succeeded { get; }
		public ResponseStatus Status { get; }
		public string LocalEndpointName { get; }
	
		// Constructors
		public AdvertisingResult(ResponseStatus status, string localEndpointName);
	}
}
