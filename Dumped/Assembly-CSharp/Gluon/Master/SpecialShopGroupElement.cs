/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class SpecialShopGroupElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _GoodsGroupName;
		[SerializeField]
		private int _Priority;
	
		// Properties
		public int Id { get; }
		public string GoodsGroupName { get; }
		public int Priority { get; }
	
		// Constructors
		public SpecialShopGroupElement();
	}
}
