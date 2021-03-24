/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.Nearby
{
	public interface IDiscoveryListener
	{
		// Methods
		void OnEndpointFound(EndpointDetails discoveredEndpoint);
		void OnEndpointLost(string lostEndpointId);
	}
}
