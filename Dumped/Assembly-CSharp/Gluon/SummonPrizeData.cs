/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonPrizeData
	{
		// Fields
		public GiftType entityType;
		public int entityId;
		public int entityQuantity;
	
		// Constructors
		public SummonPrizeData();
	
		// Methods
		public void UpdateDataFromResponse(AtgenBuildEventRewardEntityList data);
		public SummonPrizeData Clone();
	}
}
