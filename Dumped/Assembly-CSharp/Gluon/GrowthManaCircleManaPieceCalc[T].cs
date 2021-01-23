/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleManaPieceCalc<T>
	{
		// Fields
		private bool[] releasedId;
		private int[] hpDeltaForEachLimitSum;
		private int[] atkDeltaForEachLimitSum;
		private int[] hpDeltaForEachLimit;
		private int[] atkDeltaForEachLimit;
		private int[] hpRemainderForEachLimit;
		private int[] atkRemainderForEachLimit;
	
		// Constructors
		public GrowthManaCircleManaPieceCalc();
	
		// Methods
		public GrowthManaCircleManaPieceData[] Calc(List<T> circleData, CharaList charaData, int[] idArray, int[] hierarchyArray, int[] noArray, bool[] isReleaseStoryArray, ManaPieceType[] typeArray, int[] levelArray, int[] necessaryManaPointArray, int[] necessaryMaterialId1Array, int[] necessaryMaterialNum1Array, int[] necessaryMaterialId2Array, int[] necessaryMaterialNum2Array, int[] necessaryMaterialId3Array, int[] necessaryMaterialNum3Array, int[] necessaryDewPointArray, int[] necessaryGrowMaterialId1Array, int[] necessaryGrowMaterialNum1Array, out GrowthManaCircleManaPieceData[] exAbilityPieceDataList);
	}
}
