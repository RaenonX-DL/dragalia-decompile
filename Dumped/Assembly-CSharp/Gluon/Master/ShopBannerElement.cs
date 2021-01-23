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
	public class ShopBannerElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _ViewGroup;
		[SerializeField]
		private int _SortId;
		[SerializeField]
		private int _ShopType;
		[SerializeField]
		private int _GoodsId;
		[SerializeField]
		private int _TopBannerImageId;
		[SerializeField]
		private int _PopupImageId;
	
		// Properties
		public int Id { get; }
		public int ViewGroup { get; }
		public int SortId { get; }
		public int ShopType { get; }
		public int GoodsId { get; }
		public int TopBannerImageId { get; }
		public int PopupImageId { get; }
	
		// Constructors
		public ShopBannerElement();
	}
}
