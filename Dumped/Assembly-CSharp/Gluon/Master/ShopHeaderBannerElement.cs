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
	public class ShopHeaderBannerElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _ShopCategoryNum;
		[SerializeField]
		private int _BannerImageId;
		[SerializeField]
		private int _SortId;
		[SerializeField]
		private int _ShopType;
		[SerializeField]
		private int _GoodsId;
		[SerializeField]
		private string _ViewStartDate;
		[SerializeField]
		private string _ViewEndDate;
	
		// Properties
		public int Id { get; }
		public int ShopCategoryNum { get; }
		public int BannerImageId { get; }
		public int SortId { get; }
		public int ShopType { get; }
		public int GoodsId { get; }
		public string ViewStartDate { get; }
		public string ViewEndDate { get; }
	
		// Constructors
		public ShopHeaderBannerElement();
	}
}
