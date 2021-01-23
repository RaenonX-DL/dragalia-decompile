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
	public static class MessagePackSerializer
	{
		// Fields
		private static IFormatterResolver defaultResolver;
	
		// Properties
		public static IFormatterResolver DefaultResolver { get; }
	
		// Methods
		public static void SetDefaultResolver(IFormatterResolver resolver);
		public static byte[] Serialize<T>(T obj);
		public static byte[] Serialize<T>(T obj, IFormatterResolver resolver);
		public static ArraySegment<byte> SerializeUnsafe<T>(T obj, IFormatterResolver resolver);
		public static T Deserialize<T>(byte[] bytes);
		public static T Deserialize<T>(byte[] bytes, IFormatterResolver resolver);
	}
}
