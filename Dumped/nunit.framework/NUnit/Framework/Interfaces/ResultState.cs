/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Interfaces
{
	public class ResultState
	{
		// Fields
		public static readonly ResultState Inconclusive;
		public static readonly ResultState Skipped;
		public static readonly ResultState Ignored;
		public static readonly ResultState Explicit;
		public static readonly ResultState Success;
		public static readonly ResultState Failure;
		public static readonly ResultState Error;
		public static readonly ResultState Cancelled;
		public static readonly ResultState NotRunnable;
		public static readonly ResultState ChildFailure;
		public static readonly ResultState SetUpFailure;
		public static readonly ResultState SetUpError;
		public static readonly ResultState TearDownError;
		[CompilerGenerated]
		private TestStatus _Status_k__BackingField;
		[CompilerGenerated]
		private string _Label_k__BackingField;
		[CompilerGenerated]
		private FailureSite _Site_k__BackingField;
	
		// Properties
		public TestStatus Status { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string Label { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public FailureSite Site { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public ResultState(TestStatus status);
		public ResultState(TestStatus status, string label);
		public ResultState(TestStatus status, string label, FailureSite site);
		static ResultState();
	
		// Methods
		public ResultState WithSite(FailureSite site);
		public override bool Equals(object obj);
		public override int GetHashCode();
		public override string ToString();
	}
}
