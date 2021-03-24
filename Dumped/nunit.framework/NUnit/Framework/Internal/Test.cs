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

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public abstract class Test : ITest, IComparable
	{
		// Fields
		private static int _nextID;
		protected MethodInfo[] setUpMethods;
		protected MethodInfo[] tearDownMethods;
		protected ITypeInfo DeclaringTypeInfo;
		private IMethodInfo _method;
		[CompilerGenerated]
		private string _Id_k__BackingField;
		[CompilerGenerated]
		private string _Name_k__BackingField;
		[CompilerGenerated]
		private string _FullName_k__BackingField;
		[CompilerGenerated]
		private ITypeInfo _TypeInfo_k__BackingField;
		[CompilerGenerated]
		private RunState _RunState_k__BackingField;
		[CompilerGenerated]
		private IPropertyBag _Properties_k__BackingField;
		[CompilerGenerated]
		private ITest _Parent_k__BackingField;
		[CompilerGenerated]
		private object _Fixture_k__BackingField;
		[CompilerGenerated]
		private static string _IdPrefix_k__BackingField;
		[CompilerGenerated]
		private int _Seed_k__BackingField;
		[CompilerGenerated]
		private bool _RequiresThread_k__BackingField;
	
		// Properties
		public string Id { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string Name { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string FullName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string ClassName { get; }
		public virtual string MethodName { get; }
		public ITypeInfo TypeInfo { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public IMethodInfo Method { get; set; }
		public RunState RunState { [CompilerGenerated] get; [CompilerGenerated] set; }
		public abstract string XmlElementName { get; }
		public virtual string TestType { get; }
		public virtual int TestCaseCount { get; }
		public IPropertyBag Properties { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsSuite { get; }
		public abstract bool HasChildren { get; }
		public ITest Parent { [CompilerGenerated] get; [CompilerGenerated] set; }
		public abstract IList<ITest> Tests { get; }
		public virtual object Fixture { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static string IdPrefix { [CompilerGenerated] get; }
		public int Seed { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		protected Test(string name);
		protected Test(string pathName, string name);
		protected Test(ITypeInfo typeInfo);
		protected Test(IMethodInfo method);
		static Test();
	
		// Methods
		private void Initialize(string name);
		private static string GetNextId();
		public abstract TestResult MakeTestResult();
		public void ApplyAttributesToTest(ICustomAttributeProvider provider);
		protected void PopulateTestNode(TNode thisNode, bool recursive);
		public TNode ToXml(bool recursive);
		public abstract TNode AddToXml(TNode parentNode, bool recursive);
		public int CompareTo(object obj);
	}
}
