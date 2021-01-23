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
	public class SummonResultExchangeData
	{
		// Fields
		public int summonPointId;
		public int beforeExchangeSummonPoint;
		public int afterExchangeSummonpoint;
	
		// Constructors
		public SummonResultExchangeData();
	
		// Methods
		public void UpdateDataFromResponse(SummonPointList list, int ResultSummonPoint);
	}
}
