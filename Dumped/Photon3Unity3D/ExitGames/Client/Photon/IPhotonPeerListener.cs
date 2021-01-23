/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 42: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon
{
	public interface IPhotonPeerListener
	{
		// Methods
		void DebugReturn(DebugLevel level, string message);
		void OnOperationResponse(OperationResponse operationResponse);
		void OnStatusChanged(StatusCode statusCode);
		void OnEvent(EventData eventData);
	}
}
