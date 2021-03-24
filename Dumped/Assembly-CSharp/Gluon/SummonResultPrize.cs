/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonResultPrize
	{
		// Fields
		public int summonPrizeRank;
		public List<SummonPrizeData> summonPrizeList;
	
		// Constructors
		public SummonResultPrize();
	
		// Methods
		public void UpdateDataFromResponse(AtgenResultPrizeList prizeList);
	}
}
