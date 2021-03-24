/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using MessagePack.Formatters;

// Image 51: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Resolvers
{
	public sealed class BuiltinResolver : IFormatterResolver
	{
		// Fields
		public static readonly IFormatterResolver Instance;
	
		// Nested types
		private static class FormatterCache<T>
		{
			// Fields
			public static readonly IMessagePackFormatter<T> formatter;
	
			// Constructors
			static FormatterCache();
		}
	
		// Constructors
		private BuiltinResolver();
		static BuiltinResolver();
	
		// Methods
		public IMessagePackFormatter<T> GetFormatter<T>();
	}
}
