/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 48: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack
{
	public static class LZ4MessagePackSerializer
	{
		// Methods
		public static byte[] Serialize<T>(T obj);
		public static byte[] Serialize<T>(T obj, IFormatterResolver resolver);
		private static ArraySegment<byte> SerializeCore<T>(T obj, IFormatterResolver resolver);
		private static ArraySegment<byte> ToLZ4BinaryCore(ArraySegment<byte> serializedData);
		public static T Deserialize<T>(byte[] bytes);
		public static T Deserialize<T>(byte[] bytes, IFormatterResolver resolver);
		private static T DeserializeCore<T>(ArraySegment<byte> bytes, IFormatterResolver resolver);
	}
}
