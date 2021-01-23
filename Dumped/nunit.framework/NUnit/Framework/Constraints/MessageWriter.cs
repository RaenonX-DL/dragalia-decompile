/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Constraints
{
	public abstract class MessageWriter : StringWriter
	{
		// Properties
		public abstract int MaxLineLength { get; }
	
		// Constructors
		protected MessageWriter();
	
		// Methods
		public void WriteMessageLine(string message, params object[] args);
		public abstract void WriteMessageLine(int level, string message, params object[] args);
		public abstract void DisplayDifferences(ConstraintResult result);
		public abstract void DisplayDifferences(object expected, object actual);
		public abstract void DisplayDifferences(object expected, object actual, Tolerance tolerance);
		public abstract void DisplayStringDifferences(string expected, string actual, int mismatch, bool ignoreCase, bool clipping);
		public abstract void WriteActualValue(object actual);
		public abstract void WriteValue(object val);
		public abstract void WriteCollectionElements(IEnumerable collection, long start, int max);
	}
}
