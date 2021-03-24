/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon.LoadBalancing
{
	public class WebRpcResponse
	{
		// Fields
		[CompilerGenerated]
		private string _Name_k__BackingField;
		[CompilerGenerated]
		private int _ReturnCode_k__BackingField;
		[CompilerGenerated]
		private string _DebugMessage_k__BackingField;
		[CompilerGenerated]
		private Dictionary<string, object> _Parameters_k__BackingField;
	
		// Properties
		public string Name { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int ReturnCode { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string DebugMessage { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Dictionary<string, object> Parameters { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public WebRpcResponse(OperationResponse response);
	
		// Methods
		public string ToStringFull();
	}
}
