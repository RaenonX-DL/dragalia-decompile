/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using MessagePack.Formatters;

// Image 48: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Resolvers
{
	public sealed class CompositeResolver : IFormatterResolver
	{
		// Fields
		public static readonly CompositeResolver Instance;
		private static bool isFreezed;
		private static IFormatterResolver[] resolvers;
	
		// Nested types
		private static class FormatterCache<T>
		{
			// Fields
			public static readonly IMessagePackFormatter<T> formatter;
	
			// Constructors
			static FormatterCache();
		}
	
		// Constructors
		private CompositeResolver();
		static CompositeResolver();
	
		// Methods
		public static void Register(params IFormatterResolver[] resolvers);
		public static void RegisterAndSetAsDefault(params IFormatterResolver[] resolvers);
		public IMessagePackFormatter<T> GetFormatter<T>();
	}
}
