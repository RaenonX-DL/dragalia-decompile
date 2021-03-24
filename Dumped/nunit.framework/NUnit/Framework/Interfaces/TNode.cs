/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using System.Xml;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Interfaces
{
	public class TNode
	{
		// Fields
		private static readonly Regex InvalidXmlCharactersRegex;
		[CompilerGenerated]
		private string _Name_k__BackingField;
		[CompilerGenerated]
		private string _Value_k__BackingField;
		[CompilerGenerated]
		private bool _ValueIsCDATA_k__BackingField;
		[CompilerGenerated]
		private AttributeDictionary _Attributes_k__BackingField;
		[CompilerGenerated]
		private NodeList _ChildNodes_k__BackingField;
		[CompilerGenerated]
		private static MatchEvaluator CS___9__CachedAnonymousMethodDelegate1;
	
		// Properties
		public string Name { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string Value { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool ValueIsCDATA { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public AttributeDictionary Attributes { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public NodeList ChildNodes { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string OuterXml { get; }
	
		// Constructors
		public TNode(string name);
		public TNode(string name, string value);
		public TNode(string name, string value, bool valueIsCDATA);
		static TNode();
	
		// Methods
		public TNode AddElement(string name);
		public TNode AddElement(string name, string value);
		public TNode AddElementWithCDATA(string name, string value);
		public void AddAttribute(string name, string value);
		public void WriteTo(XmlWriter writer);
		private static string EscapeInvalidXmlCharacters(string str);
		private static string CharToUnicodeSequence(char symbol);
		private void WriteCDataTo(XmlWriter writer);
		[CompilerGenerated]
		private static string _EscapeInvalidXmlCharacters_b__0(Match match);
	}
}
