/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExitGames.Client;

// Image 44: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon
{
	public class Protocol16 : IProtocol
	{
		// Fields
		private readonly byte[] versionBytes;
		private readonly byte[] memShort;
		private readonly long[] memLongBlock;
		private readonly byte[] memLongBlockBytes;
		private static readonly float[] memFloatBlock;
		private static readonly byte[] memFloatBlockBytes;
		private readonly double[] memDoubleBlock;
		private readonly byte[] memDoubleBlockBytes;
		private readonly byte[] memInteger;
		private readonly byte[] memLong;
		private readonly byte[] memFloat;
		private readonly byte[] memDouble;
		private byte[] memString;
	
		// Properties
		internal override string protocolType { get; }
		internal override byte[] VersionBytes { get; }
	
		// Nested types
		public enum GpType : byte
		{
			Unknown = 0,
			Null = 42,
			Dictionary = 68,
			StringArray = 97,
			Byte = 98,
			Custom = 99,
			Double = 100,
			EventData = 101,
			Float = 102,
			Hashtable = 104,
			Integer = 105,
			Short = 107,
			Long = 108,
			IntegerArray = 110,
			Boolean = 111,
			OperationResponse = 112,
			OperationRequest = 113,
			String = 115,
			ByteArray = 120,
			Array = 121,
			ObjectArray = 122
		}
	
		// Constructors
		public Protocol16();
		static Protocol16();
	
		// Methods
		private bool SerializeCustom(StreamBuffer dout, object serObject);
		private object DeserializeCustom(StreamBuffer din, byte customTypeCode);
		private Type GetTypeOfCode(byte typeCode);
		private GpType GetCodeOfType(Type type);
		private Array CreateArrayByType(byte arrayType, short length);
		private void SerializeOperationRequest(StreamBuffer stream, OperationRequest serObject, bool setType);
		public override void SerializeOperationRequest(StreamBuffer stream, byte operationCode, Dictionary<byte, object> parameters, bool setType);
		public override OperationRequest DeserializeOperationRequest(StreamBuffer din);
		public override void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType);
		public override OperationResponse DeserializeOperationResponse(StreamBuffer stream);
		public override void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType);
		public override EventData DeserializeEventData(StreamBuffer din);
		private void SerializeParameterTable(StreamBuffer stream, Dictionary<byte, object> parameters);
		private Dictionary<byte, object> DeserializeParameterTable(StreamBuffer stream);
		public override void Serialize(StreamBuffer dout, object serObject, bool setType);
		private void SerializeByte(StreamBuffer dout, byte serObject, bool setType);
		private void SerializeBoolean(StreamBuffer dout, bool serObject, bool setType);
		public override void SerializeShort(StreamBuffer dout, short serObject, bool setType);
		private void SerializeInteger(StreamBuffer dout, int serObject, bool setType);
		private void SerializeLong(StreamBuffer dout, long serObject, bool setType);
		private void SerializeFloat(StreamBuffer dout, float serObject, bool setType);
		private void SerializeDouble(StreamBuffer dout, double serObject, bool setType);
		public override void SerializeString(StreamBuffer dout, string serObject, bool setType);
		private void SerializeArray(StreamBuffer dout, Array serObject, bool setType);
		private void SerializeByteArray(StreamBuffer dout, byte[] serObject, bool setType);
		private void SerializeIntArrayOptimized(StreamBuffer inWriter, int[] serObject, bool setType);
		private void SerializeObjectArray(StreamBuffer dout, object[] objects, bool setType);
		private void SerializeHashTable(StreamBuffer dout, Hashtable serObject, bool setType);
		private void SerializeDictionary(StreamBuffer dout, IDictionary serObject, bool setType);
		private void SerializeDictionaryHeader(StreamBuffer writer, Type dictType);
		private void SerializeDictionaryHeader(StreamBuffer writer, object dict, out bool setKeyType, out bool setValueType);
		private void SerializeDictionaryElements(StreamBuffer writer, object dict, bool setKeyType, bool setValueType);
		public override object Deserialize(StreamBuffer din, byte type);
		public override byte DeserializeByte(StreamBuffer din);
		private bool DeserializeBoolean(StreamBuffer din);
		public override short DeserializeShort(StreamBuffer din);
		private int DeserializeInteger(StreamBuffer din);
		private long DeserializeLong(StreamBuffer din);
		private float DeserializeFloat(StreamBuffer din);
		private double DeserializeDouble(StreamBuffer din);
		private string DeserializeString(StreamBuffer din);
		private Array DeserializeArray(StreamBuffer din);
		private byte[] DeserializeByteArray(StreamBuffer din);
		private int[] DeserializeIntArray(StreamBuffer din);
		private string[] DeserializeStringArray(StreamBuffer din);
		private object[] DeserializeObjectArray(StreamBuffer din);
		private Hashtable DeserializeHashTable(StreamBuffer din);
		private IDictionary DeserializeDictionary(StreamBuffer din);
		private bool DeserializeDictionaryArray(StreamBuffer din, short size, out Array arrayResult);
		private Type DeserializeDictionaryType(StreamBuffer reader, out byte keyTypeCode, out byte valTypeCode);
	}
}
