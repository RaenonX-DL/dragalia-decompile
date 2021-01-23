/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 42: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon
{
	public class OperationResponse
	{
		// Fields
		public byte OperationCode;
		public short ReturnCode;
		public string DebugMessage;
		public Dictionary<byte, object> Parameters;
	
		// Properties
		public object this[byte parameterCode] { get => default; }
	
		// Constructors
		public OperationResponse();
	
		// Methods
		public override string ToString();
		public string ToStringFull();
	}
}
