/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework.Constraints;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public class TextMessageWriter : MessageWriter
	{
		// Fields
		private static readonly int DEFAULT_LINE_LENGTH;
		public static readonly string Pfx_Expected;
		public static readonly string Pfx_Actual;
		public static readonly int PrefixLength;
		private int maxLineLength;
	
		// Properties
		public override int MaxLineLength { get; }
	
		// Constructors
		public TextMessageWriter(string userMessage, params object[] args);
		static TextMessageWriter();
	
		// Methods
		public override void WriteMessageLine(int level, string message, params object[] args);
		public override void DisplayDifferences(ConstraintResult result);
		public override void DisplayDifferences(object expected, object actual);
		public override void DisplayDifferences(object expected, object actual, Tolerance tolerance);
		public override void DisplayStringDifferences(string expected, string actual, int mismatch, bool ignoreCase, bool clipping);
		public override void WriteActualValue(object actual);
		public override void WriteValue(object val);
		public override void WriteCollectionElements(IEnumerable collection, long start, int max);
		private void WriteExpectedLine(ConstraintResult result);
		private void WriteExpectedLine(object expected);
		private void WriteExpectedLine(object expected, Tolerance tolerance);
		private void WriteActualLine(ConstraintResult result);
		private void WriteActualLine(object actual);
		private void WriteCaretLine(int mismatch);
	}
}
