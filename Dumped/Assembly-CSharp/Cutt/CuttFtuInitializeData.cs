/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttFtuInitializeData
	{
		// Fields
		public int characterIndex;
		public ObjectType type;
		public string targetObjectName;
		public Conditions conditions;
		public string[] dataString;
	
		// Nested types
		public enum ObjectType
		{
			Text = 0,
			Texture = 1
		}
	
		public enum Conditions
		{
			Fixed = 0,
			Difficulty = 1
		}
	
		// Constructors
		public CuttFtuInitializeData(ObjectType type, string targetObjectName, Conditions conditions, string[] array);
	}
}
