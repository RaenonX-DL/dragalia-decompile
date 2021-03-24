/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Principal;
using NUnit.Compatibility;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit.Framework.Interfaces;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public class TestExecutionContext : LongLivedMarshalByRefObject, ITestExecutionContext
	{
		// Fields
		private TestExecutionContext _priorContext;
		private TestExecutionStatus _executionStatus;
		private ITestListener _listener;
		private int _assertCount;
		private CultureInfo _currentCulture;
		private CultureInfo _currentUICulture;
		private TestResult _currentResult;
		private IPrincipal _currentPrincipal;
		private static readonly string CONTEXT_KEY;
		[CompilerGenerated]
		private Test _CurrentTest_k__BackingField;
		[CompilerGenerated]
		private TextWriter _OutWriter_k__BackingField;
		[CompilerGenerated]
		private object _TestObject_k__BackingField;
		[CompilerGenerated]
		private int _TestCaseTimeout_k__BackingField;
		[CompilerGenerated]
		private List<ITestAction> _UpstreamActions_k__BackingField;
		[CompilerGenerated]
		private ValueFormatter _CurrentValueFormatter_k__BackingField;
		[CompilerGenerated]
		private bool _IsSingleThreaded_k__BackingField;
		[CompilerGenerated]
		private static ValueFormatter CS___9__CachedAnonymousMethodDelegate1;
	
		// Properties
		public static ITestExecutionContext CurrentContext { get; }
		public Test CurrentTest { [CompilerGenerated] get; }
		public TestResult CurrentResult { get; set; }
		public TextWriter OutWriter { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public object TestObject { [CompilerGenerated] get; [CompilerGenerated] set; }
		public TestExecutionStatus ExecutionStatus { get; }
		internal ITestListener Listener { get; }
		public int TestCaseTimeout { [CompilerGenerated] set; }
		public List<ITestAction> UpstreamActions { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public ValueFormatter CurrentValueFormatter { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsSingleThreaded { [CompilerGenerated] set; }
	
		// Constructors
		public TestExecutionContext();
		static TestExecutionContext();
	
		// Methods
		public static TestExecutionContext GetTestExecutionContext();
		public void IncrementAssertCount();
		public override object InitializeLifetimeService();
		[CompilerGenerated]
		private static string _.ctor_b__0(object val);
	}
}
