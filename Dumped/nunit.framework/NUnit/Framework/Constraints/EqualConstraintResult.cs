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

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Constraints
{
	public class EqualConstraintResult : ConstraintResult
	{
		// Fields
		private object expectedValue;
		private Tolerance tolerance;
		private bool caseInsensitive;
		private bool clipStrings;
		private IList<NUnitEqualityComparer.FailurePoint> failurePoints;
		private static readonly string StringsDiffer_1;
		private static readonly string StringsDiffer_2;
		private static readonly string StreamsDiffer_1;
		private static readonly string StreamsDiffer_2;
		private static readonly string CollectionType_1;
		private static readonly string CollectionType_2;
		private static readonly string ValuesDiffer_1;
		private static readonly string ValuesDiffer_2;
	
		// Constructors
		public EqualConstraintResult(EqualConstraint constraint, object actual, bool hasSucceeded);
		static EqualConstraintResult();
	
		// Methods
		public override void WriteMessageTo(MessageWriter writer);
		private void DisplayDifferences(MessageWriter writer, object expected, object actual, int depth);
		private void DisplayStringDifferences(MessageWriter writer, string expected, string actual);
		private void DisplayStreamDifferences(MessageWriter writer, Stream expected, Stream actual, int depth);
		private void DisplayCollectionDifferences(MessageWriter writer, ICollection expected, ICollection actual, int depth);
		private void DisplayTypesAndSizes(MessageWriter writer, IEnumerable expected, IEnumerable actual, int indent);
		private void DisplayFailurePoint(MessageWriter writer, IEnumerable expected, IEnumerable actual, NUnitEqualityComparer.FailurePoint failurePoint, int indent);
		private void DisplayEnumerableDifferences(MessageWriter writer, IEnumerable expected, IEnumerable actual, int depth);
	}
}
