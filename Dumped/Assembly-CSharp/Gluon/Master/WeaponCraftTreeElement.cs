/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class WeaponCraftTreeElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _CraftGroupId;
		[SerializeField]
		private int _CraftStep;
		[SerializeField]
		private int _CraftNodeId;
		[SerializeField]
		private int _CraftWeaponId;
		[SerializeField]
		private int _ParentCraftNodeId;
	
		// Properties
		public int Id { get; }
		public int CraftGroupId { get; }
		public int CraftStep { get; }
		public int CraftNodeId { get; }
		public int CraftWeaponId { get; }
		public int ParentCraftNodeId { get; }
	
		// Constructors
		public WeaponCraftTreeElement();
	}
}
