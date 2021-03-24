/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class BGParts : MonoBehaviour
	{
		// Fields
		[EnumFlags]
		[SerializeField]
		private BGPartsFlags partsFlags;
	
		// Properties
		public BGPartsFlags PartsFlags { get; }
	
		// Nested types
		[Flags]
		public enum BGPartsFlags
		{
	
		}
	
		// Constructors
		public BGParts();
	
		// Methods
		public void OrPartsFlag(BGPartsFlags f);
		public void ResetPartsFlag(BGPartsFlags f);
		public void ClearPartsFlag();
		public bool IsPartsFlags(BGPartsFlags f);
	}
}
