/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal.Execution
{
	public static class CommandBuilder
	{
		// Methods
		public static TestCommand MakeOneTimeSetUpCommand(TestSuite suite, List<SetUpTearDownItem> setUpTearDown, List<TestActionItem> actions);
		public static TestCommand MakeOneTimeTearDownCommand(TestSuite suite, List<SetUpTearDownItem> setUpTearDownItems, List<TestActionItem> actions);
		public static TestCommand MakeTestCommand(TestMethod test);
		public static SkipCommand MakeSkipCommand(NUnit.Framework.Internal.Test test);
		public static List<SetUpTearDownItem> BuildSetUpTearDownList(Type fixtureType, Type setUpType, Type tearDownType);
		private static SetUpTearDownItem BuildNode(Type fixtureType, IList<MethodInfo> setUpMethods, IList<MethodInfo> tearDownMethods);
		private static List<MethodInfo> SelectMethodsByDeclaringType(Type type, IList<MethodInfo> methods);
	}
}
