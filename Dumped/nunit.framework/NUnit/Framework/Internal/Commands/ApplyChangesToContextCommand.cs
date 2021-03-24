/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal.Commands
{
	public class ApplyChangesToContextCommand : DelegatingTestCommand
	{
		// Fields
		private IEnumerable<IApplyToContext> _changes;
	
		// Constructors
		public ApplyChangesToContextCommand(TestCommand innerCommand, IEnumerable<IApplyToContext> changes);
	
		// Methods
		public void ApplyChanges(ITestExecutionContext context);
		public override TestResult Execute(ITestExecutionContext context);
	}
}
