﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using MessagePack;
using MessagePack.Formatters;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Resolvers
{
	public class GeneratedResolver : IFormatterResolver
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
		private GeneratedResolver();
		static GeneratedResolver();
	
		// Methods
		public IMessagePackFormatter<T> GetFormatter<T>();
	}
}
