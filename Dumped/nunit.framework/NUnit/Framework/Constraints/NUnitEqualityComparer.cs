/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Constraints
{
	public class NUnitEqualityComparer
	{
		// Fields
		private bool caseInsensitive;
		private bool compareAsCollection;
		private List<EqualityAdapter> externalComparers;
		private List<FailurePoint> failurePoints;
		private static readonly int BUFFER_SIZE;
		private static readonly Type GameObjectType;
		[CompilerGenerated]
		private bool _WithSameOffset_k__BackingField;
	
		// Properties
		public bool IgnoreCase { get; }
		public IList<FailurePoint> FailurePoints { get; }
		public bool WithSameOffset { [CompilerGenerated] get; }
	
		// Nested types
		public class FailurePoint
		{
			// Fields
			public long Position;
			public object ExpectedValue;
			public object ActualValue;
			public bool ExpectedHasData;
			public bool ActualHasData;
	
			// Constructors
			public FailurePoint();
		}
	
		// Constructors
		public NUnitEqualityComparer();
		static NUnitEqualityComparer();
	
		// Methods
		public bool AreEqual(object x, object y, ref Tolerance tolerance);
		private static MethodInfo FirstImplementsIEquatableOfSecond(Type first, Type second);
		private static IList<KeyValuePair<Type, MethodInfo>> GetEquatableGenericArguments(Type type);
		private static bool InvokeFirstIEquatableEqualsSecond(object first, object second, MethodInfo equals);
		private EqualityAdapter GetExternalComparer(object x, object y);
		private bool ArraysEqual(Array x, Array y, ref Tolerance tolerance);
		private bool DictionariesEqual(IDictionary x, IDictionary y, ref Tolerance tolerance);
		private bool DictionaryEntriesEqual(DictionaryEntry x, DictionaryEntry y, ref Tolerance tolerance);
		private bool StringsEqual(string x, string y);
		private bool CharsEqual(char x, char y);
		private bool EnumerablesEqual(IEnumerable x, IEnumerable y, ref Tolerance tolerance);
		private static bool DirectoriesEqual(DirectoryInfo x, DirectoryInfo y);
		private bool StreamsEqual(Stream x, Stream y);
		internal static void CheckGameObjectReference<T>(ref T value);
	}
}
