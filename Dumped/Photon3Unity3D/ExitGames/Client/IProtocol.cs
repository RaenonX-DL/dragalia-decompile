/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExitGames.Client.Photon;

// Image 44: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client
{
	public abstract class IProtocol
	{
		// Properties
		internal abstract string protocolType { get; }
		internal abstract byte[] VersionBytes { get; }
	
		// Constructors
		protected IProtocol();
	
		// Methods
		public abstract void Serialize(StreamBuffer dout, object serObject, bool setType);
		public abstract void SerializeShort(StreamBuffer dout, short serObject, bool setType);
		public abstract void SerializeString(StreamBuffer dout, string serObject, bool setType);
		public abstract void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType);
		public abstract void SerializeOperationRequest(StreamBuffer stream, byte operationCode, Dictionary<byte, object> parameters, bool setType);
		public abstract void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType);
		public abstract object Deserialize(StreamBuffer din, byte type);
		public abstract short DeserializeShort(StreamBuffer din);
		public abstract byte DeserializeByte(StreamBuffer din);
		public abstract EventData DeserializeEventData(StreamBuffer din);
		public abstract OperationRequest DeserializeOperationRequest(StreamBuffer din);
		public abstract OperationResponse DeserializeOperationResponse(StreamBuffer stream);
		public byte[] Serialize(object obj);
	}
}
