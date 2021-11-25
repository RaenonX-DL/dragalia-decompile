using System.Collections.Generic;
using Gluon.Http;

namespace Gluon
{
	public class GrowthManaCircleManaPieceCalc<T>
	{
		private bool[] releasedId;

		private int[] hpDeltaForEachLimitSum;

		private int[] atkDeltaForEachLimitSum;

		private int[] hpDeltaForEachLimit;

		private int[] atkDeltaForEachLimit;

		private int[] hpRemainderForEachLimit;

		private int[] atkRemainderForEachLimit;

		public GrowthManaCircleManaPieceData[] Calc(List<T> circleData, CharaList charaData, int[] idArray, int[] hierarchyArray, int[] noArray, bool[] isReleaseStoryArray, ManaPieceType[] typeArray, int[] levelArray, int[] necessaryManaPointArray, int[] necessaryMaterialId1Array, int[] necessaryMaterialNum1Array, int[] necessaryMaterialId2Array, int[] necessaryMaterialNum2Array, int[] necessaryMaterialId3Array, int[] necessaryMaterialNum3Array, int[] necessaryDewPointArray, int[] necessaryGrowMaterialId1Array, int[] necessaryGrowMaterialNum1Array, int[] necessaryUniqueMaterialId1Array, int[] necessaryUniqueMaterialNum1Array, int[] necessaryUniqueMaterialId2Array, int[] necessaryUniqueMaterialNum2Array, out GrowthManaCircleManaPieceData[] exAbilityPieceDataList)
		{
			return null;
		}
	}
}
