/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class ShopGetProductListResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public ProductList[] product_list;
			public UpdateDataList update_data_list;
			public int infancy_paid_diamond_limit;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public ShopGetProductListResponse();
	}
}
