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
	public class WeaponCraftGroupSeriesElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _CraftGroupName;
		[SerializeField]
		private int _SortId;
	
		// Properties
		public int Id { get; }
		public string CraftGroupName { get; }
		public int SortId { get; }
	
		// Constructors
		public WeaponCraftGroupSeriesElement();
	}
}
