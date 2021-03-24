/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.Nearby
{
	public struct NearbyConnectionConfiguration
	{
		// Fields
		public const int MaxUnreliableMessagePayloadLength = 1168;
		public const int MaxReliableMessagePayloadLength = 4096;
		private readonly Action<InitializationStatus> mInitializationCallback;
		private readonly long mLocalClientId;
	
		// Properties
		public long LocalClientId { get; }
		public Action<InitializationStatus> InitializationCallback { get; }
	
		// Constructors
		public NearbyConnectionConfiguration(Action<InitializationStatus> callback, long localClientId);
	}
}
