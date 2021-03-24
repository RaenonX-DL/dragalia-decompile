/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using NUnit.Framework.Interfaces;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public abstract class TestResult : ITestResult
	{
		// Fields
		internal const double MIN_DURATION = 1E-06;
		internal static readonly string CHILD_ERRORS_MESSAGE;
		internal static readonly string CHILD_IGNORE_MESSAGE;
		private StringBuilder _output;
		private double _duration;
		protected int InternalAssertCount;
		private ResultState _resultState;
		private string _message;
		private string _stackTrace;
		[CompilerGenerated]
		private ITest _Test_k__BackingField;
		[CompilerGenerated]
		private DateTime _StartTime_k__BackingField;
		[CompilerGenerated]
		private DateTime _EndTime_k__BackingField;
		[CompilerGenerated]
		private TextWriter _OutWriter_k__BackingField;
	
		// Properties
		public ITest Test { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public ResultState ResultState { get; private set; }
		public virtual string Name { get; }
		public virtual string FullName { get; }
		public double Duration { get; set; }
		public DateTime StartTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public DateTime EndTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string Message { get; private set; }
		public virtual string StackTrace { get; private set; }
		public int AssertCount { get; }
		public abstract int FailCount { get; }
		public abstract int PassCount { get; }
		public abstract int SkipCount { get; }
		public abstract int InconclusiveCount { get; }
		public abstract bool HasChildren { get; }
		public abstract IEnumerable<ITestResult> Children { get; }
		public TextWriter OutWriter { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string Output { get; }
	
		// Constructors
		public TestResult(ITest test);
		static TestResult();
	
		// Methods
		public TNode ToXml(bool recursive);
		public virtual TNode AddToXml(TNode parentNode, bool recursive);
		public void SetResult(ResultState resultState);
		public void SetResult(ResultState resultState, string message);
		public void SetResult(ResultState resultState, string message, string stackTrace);
		public void RecordException(Exception ex);
		public void RecordException(Exception ex, FailureSite site);
		public void RecordTearDownException(Exception ex);
		private TNode AddReasonElement(TNode targetNode);
		private TNode AddFailureElement(TNode targetNode);
		private TNode AddOutputElement(TNode targetNode);
	}
}
