/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Constraints
{
	internal static class MsgUtils
	{
		// Fields
		private static readonly string Fmt_Null;
		private static readonly string Fmt_EmptyString;
		private static readonly string Fmt_EmptyCollection;
		private static readonly string Fmt_String;
		private static readonly string Fmt_Char;
		private static readonly string Fmt_DateTime;
		private static readonly string Fmt_DateTimeOffset;
		private static readonly string Fmt_ValueType;
		private static readonly string Fmt_Default;
		[CompilerGenerated]
		private static ValueFormatter _DefaultValueFormatter_k__BackingField;
		[CompilerGenerated]
		private static ValueFormatter CS___9__CachedAnonymousMethodDelegate15;
		[CompilerGenerated]
		private static ValueFormatterFactory CS___9__CachedAnonymousMethodDelegate16;
		[CompilerGenerated]
		private static ValueFormatterFactory CS___9__CachedAnonymousMethodDelegate17;
		[CompilerGenerated]
		private static ValueFormatterFactory CS___9__CachedAnonymousMethodDelegate18;
		[CompilerGenerated]
		private static ValueFormatterFactory CS___9__CachedAnonymousMethodDelegate19;
		[CompilerGenerated]
		private static ValueFormatterFactory CS___9__CachedAnonymousMethodDelegate1a;
		[CompilerGenerated]
		private static ValueFormatterFactory CS___9__CachedAnonymousMethodDelegate1b;
		[CompilerGenerated]
		private static ValueFormatterFactory CS___9__CachedAnonymousMethodDelegate1c;
		[CompilerGenerated]
		private static ValueFormatterFactory CS___9__CachedAnonymousMethodDelegate1d;
		[CompilerGenerated]
		private static ValueFormatterFactory CS___9__CachedAnonymousMethodDelegate1e;
		[CompilerGenerated]
		private static ValueFormatterFactory CS___9__CachedAnonymousMethodDelegate1f;
	
		// Properties
		public static ValueFormatter DefaultValueFormatter { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20
		{
			// Fields
			public ValueFormatter next;
	
			// Constructors
			public __c__DisplayClass20();
	
			// Methods
			public string _.cctor_b__2(object val);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22
		{
			// Fields
			public ValueFormatter next;
	
			// Constructors
			public __c__DisplayClass22();
	
			// Methods
			public string _.cctor_b__4(object val);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24
		{
			// Fields
			public ValueFormatter next;
	
			// Constructors
			public __c__DisplayClass24();
	
			// Methods
			public string _.cctor_b__6(object val);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26
		{
			// Fields
			public ValueFormatter next;
	
			// Constructors
			public __c__DisplayClass26();
	
			// Methods
			public string _.cctor_b__8(object val);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28
		{
			// Fields
			public ValueFormatter next;
	
			// Constructors
			public __c__DisplayClass28();
	
			// Methods
			public string _.cctor_b__a(object val);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2a
		{
			// Fields
			public ValueFormatter next;
	
			// Constructors
			public __c__DisplayClass2a();
	
			// Methods
			public string _.cctor_b__c(object val);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2c
		{
			// Fields
			public ValueFormatter next;
	
			// Constructors
			public __c__DisplayClass2c();
	
			// Methods
			public string _.cctor_b__e(object val);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2e
		{
			// Fields
			public ValueFormatter next;
	
			// Constructors
			public __c__DisplayClass2e();
	
			// Methods
			public string _.cctor_b__10(object val);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30
		{
			// Fields
			public ValueFormatter next;
	
			// Constructors
			public __c__DisplayClass30();
	
			// Methods
			public string _.cctor_b__12(object val);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32
		{
			// Fields
			public ValueFormatter next;
	
			// Constructors
			public __c__DisplayClass32();
	
			// Methods
			public string _.cctor_b__14(object val);
		}
	
		// Constructors
		static MsgUtils();
	
		// Methods
		public static void AddFormatter(ValueFormatterFactory formatterFactory);
		public static string FormatValue(object val);
		public static string FormatCollection(IEnumerable collection, long start, int max);
		private static string FormatArray(Array array);
		private static string FormatString(string s);
		private static string FormatDouble(double d);
		private static string FormatFloat(float f);
		private static string FormatDecimal(decimal d);
		private static string FormatDateTime(DateTime dt);
		private static string FormatDateTimeOffset(DateTimeOffset dto);
		public static string GetTypeRepresentation(object obj);
		public static string EscapeControlChars(string s);
		public static string EscapeNullCharacters(string s);
		public static string GetArrayIndicesAsString(int[] indices);
		public static int[] GetArrayIndicesFromCollectionIndex(IEnumerable collection, long index);
		public static string ClipString(string s, int maxStringLength, int clipStart);
		public static void ClipExpectedAndActual(ref string expected, ref string actual, int maxDisplayLength, int mismatch);
		public static int FindMismatchPosition(string expected, string actual, int istart, bool ignoreCase);
		[CompilerGenerated]
		private static string _.cctor_b__0(object val);
		[CompilerGenerated]
		private static ValueFormatter _.cctor_b__1(ValueFormatter next);
		[CompilerGenerated]
		private static ValueFormatter _.cctor_b__3(ValueFormatter next);
		[CompilerGenerated]
		private static ValueFormatter _.cctor_b__5(ValueFormatter next);
		[CompilerGenerated]
		private static ValueFormatter _.cctor_b__7(ValueFormatter next);
		[CompilerGenerated]
		private static ValueFormatter _.cctor_b__9(ValueFormatter next);
		[CompilerGenerated]
		private static ValueFormatter _.cctor_b__b(ValueFormatter next);
		[CompilerGenerated]
		private static ValueFormatter _.cctor_b__d(ValueFormatter next);
		[CompilerGenerated]
		private static ValueFormatter _.cctor_b__f(ValueFormatter next);
		[CompilerGenerated]
		private static ValueFormatter _.cctor_b__11(ValueFormatter next);
		[CompilerGenerated]
		private static ValueFormatter _.cctor_b__13(ValueFormatter next);
	}
}
