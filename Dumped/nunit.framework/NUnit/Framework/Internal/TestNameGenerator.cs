/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public class TestNameGenerator
	{
		// Fields
		public static string DefaultTestNamePattern;
		private string _pattern;
		private List<NameFragment> _fragments;
	
		// Nested types
		private abstract class NameFragment
		{
			// Constructors
			protected NameFragment();
	
			// Methods
			public virtual string GetText(TestMethod testMethod, object[] args);
			public abstract string GetText(MethodInfo method, object[] args);
			protected static void AppendGenericTypeNames(StringBuilder sb, MethodInfo method);
			protected static string GetDisplayString(object arg, int stringMax);
			private static string EscapeSingleChar(char c);
			private static string EscapeCharInString(char c);
			private static string EscapeControlChar(char c);
		}
	
		private class TestIDFragment : NameFragment
		{
			// Constructors
			public TestIDFragment();
	
			// Methods
			public override string GetText(MethodInfo method, object[] args);
			public override string GetText(TestMethod testMethod, object[] args);
		}
	
		private class FixedTextFragment : NameFragment
		{
			// Fields
			private string _text;
	
			// Constructors
			public FixedTextFragment(string text);
	
			// Methods
			public override string GetText(MethodInfo method, object[] args);
		}
	
		private class MethodNameFragment : NameFragment
		{
			// Constructors
			public MethodNameFragment();
	
			// Methods
			public override string GetText(MethodInfo method, object[] args);
		}
	
		private class NamespaceFragment : NameFragment
		{
			// Constructors
			public NamespaceFragment();
	
			// Methods
			public override string GetText(MethodInfo method, object[] args);
		}
	
		private class MethodFullNameFragment : NameFragment
		{
			// Constructors
			public MethodFullNameFragment();
	
			// Methods
			public override string GetText(MethodInfo method, object[] args);
		}
	
		private class ClassNameFragment : NameFragment
		{
			// Constructors
			public ClassNameFragment();
	
			// Methods
			public override string GetText(MethodInfo method, object[] args);
		}
	
		private class ClassFullNameFragment : NameFragment
		{
			// Constructors
			public ClassFullNameFragment();
	
			// Methods
			public override string GetText(MethodInfo method, object[] args);
		}
	
		private class ArgListFragment : NameFragment
		{
			// Fields
			private int _maxStringLength;
	
			// Constructors
			public ArgListFragment(int maxStringLength);
	
			// Methods
			public override string GetText(MethodInfo method, object[] arglist);
		}
	
		private class ArgumentFragment : NameFragment
		{
			// Fields
			private int _index;
			private int _maxStringLength;
	
			// Constructors
			public ArgumentFragment(int index, int maxStringLength);
	
			// Methods
			public override string GetText(MethodInfo method, object[] args);
		}
	
		// Constructors
		public TestNameGenerator();
		public TestNameGenerator(string pattern);
		static TestNameGenerator();
	
		// Methods
		public string GetDisplayName(TestMethod testMethod, object[] args);
		private static List<NameFragment> BuildFragmentList(string pattern);
	}
}
