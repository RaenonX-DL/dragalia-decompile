/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	public class EffectTableElement
	{
		// Fields
		[SerializeField]
		private string fileName;
		[SerializeField]
		private string groupName;
		[SerializeField]
		private int poolCount;
	
		// Properties
		public string FileName { get; }
		public string GroupName { get; }
		public int PoolCount { get; }
	
		// Constructors
		public EffectTableElement(string fileName, string groupName, int poolCount);
	}
}
