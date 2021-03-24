/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace com.adjust.sdk
{
	internal class JSONLazyCreator : JSONNode
	{
		// Fields
		private JSONNode m_Node;
		private string m_Key;
	
		// Properties
		public override JSONNode this[int aIndex] { get => default; set {} }
		public override JSONNode this[string aKey] { get => default; set {} }
		public override int AsInt { get; set; }
		public override float AsFloat { get; set; }
		public override double AsDouble { get; set; }
		public override bool AsBool { get; set; }
		public override JSONArray AsArray { get; }
		public override JSONClass AsObject { get; }
	
		// Constructors
		public JSONLazyCreator(JSONNode aNode);
		public JSONLazyCreator(JSONNode aNode, string aKey);
	
		// Methods
		private void Set(JSONNode aVal);
		public override void Add(JSONNode aItem);
		public override void Add(string aKey, JSONNode aItem);
		public static bool operator ==(JSONLazyCreator a, object b);
		public static bool operator !=(JSONLazyCreator a, object b);
		public override bool Equals(object obj);
		public override int GetHashCode();
		public override string ToString();
		public override string ToString(string aPrefix);
	}
}
