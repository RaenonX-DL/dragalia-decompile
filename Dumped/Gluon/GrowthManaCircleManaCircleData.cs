using System;
using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class GrowthManaCircleManaCircleData : MonoBehaviour
	{
		private class CircleDataList<T>
		{
			public List<T> circleData;

			public CircleDataList(GrowthManaCircleManaCircleData self, List<T> list, CharaList charaData, Action action)
			{
			}
		}

		public GrowthManaCircleManaPieceData[] manaPieceDataList;

		public GrowthManaCircleManaPieceData[] exAbilityPieceDataList;

		private int[] idArray;

		private int[] hierarchyArray;

		private int[] noArray;

		private bool[] isReleaseStoryArray;

		private ManaPieceType[] typeArray;

		private int[] levelArray;

		private int[] necessaryManaPointArray;

		private int[] necessaryMaterialId1Array;

		private int[] necessaryMaterialNum1Array;

		private int[] necessaryMaterialId2Array;

		private int[] necessaryMaterialNum2Array;

		private int[] necessaryMaterialId3Array;

		private int[] necessaryMaterialNum3Array;

		private int[] necessaryDewPointArray;

		private int[] necessaryGrowMaterialIdArray;

		private int[] necessaryGrowMaterialNumArray;

		private int[] necessaryUniqueMaterialId1Array;

		private int[] necessaryUniqueMaterialNum1Array;

		private int[] necessaryUniqueMaterialId2Array;

		private int[] necessaryUniqueMaterialNum2Array;

		private int[] stepCountArray;

		private void CreatePropertyCopyArray(int count)
		{
		}

		public void Init(string circleName, CharaList charaData)
		{
		}

		private int SetPieceDataWithMaterial(int index, int pieceElementGroupId, ManaPieceType type, ref int level, ref int step)
		{
			return default(int);
		}

		private int SetPieceDataWithGrowMaterial(int index, int pieceElementGroupId, ManaPieceType type, ref int level, ref int step, int growId, int growNum)
		{
			return default(int);
		}

		public GrowthManaCircleManaPieceData GetPieceData(int circleIndex, int pieceIndex)
		{
			return null;
		}

		public GrowthManaCircleManaPieceData GetPieceData(int dataListIndex)
		{
			return null;
		}

		public void ReleaseManaPiece(int circleIndex, int pieceIndex)
		{
		}

		public void ReleaseManaPiece(int dataListIndex)
		{
		}

		public bool IsManaPieceReleased(int circleIndex, int pieceIndex)
		{
			return default(bool);
		}

		public bool IsManaPieceReleased(int dataListIndex)
		{
			return default(bool);
		}

		public List<GrowthManaCircleManaPieceData> GetAutoReleasablePointList(int circleIndex, int currentMP, out int requiredMP, out int requiredDew, out bool isMaterialsufficient)
		{
			return null;
		}

		public List<GrowthManaCircleManaPieceData> GetAutoReleasablePointListGrowMaterial(int circleIndex)
		{
			return null;
		}

		public AutoReleasableAllCirclePointData GetAutoReleasableSecondManaCirclePointListGrowMaterial()
		{
			return null;
		}

		public AutoReleasableAllCirclePointData GetReleaseSecondCirclePointDatasByPieceData(GrowthManaCircleModel model, GrowthManaCircleManaPieceData pieceData)
		{
			return null;
		}

		public AutoReleasableAllCirclePointData GetAutoReleasableFirstCirclePointList(GrowthManaCircleModel model, int circleIndex)
		{
			return null;
		}

		private AutoReleasableAllCirclePointData GetAutoReleasableAllCirclePointDatas(GrowthManaCircleModel model, GrowthManaCircleManaPieceData[] circlePoints, bool isUseGrowMaterial)
		{
			return null;
		}

		public AutoReleasableAllCirclePointData GetReleaseFirstCirclePointDatasByCircleIndex(GrowthManaCircleModel model, int circleIndex, int targetCircleIndex)
		{
			return null;
		}

		public AutoReleasableAllCirclePointData GetReleaseFirstCirclePointDatasByPieceData(GrowthManaCircleModel model, int circleIndex, GrowthManaCircleManaPieceData pieceData)
		{
			return null;
		}

		private AutoReleasableAllCirclePointData GetReleaseCirclePointDatasByCirclePoints(GrowthManaCircleModel model, GrowthManaCircleManaPieceData[] circlePoints, bool isUseGrowMaterial, bool isAddLimitBreakPiece = false)
		{
			return null;
		}

		private bool IsReleasableLimitBreakPiece(GrowthManaCircleModel model, int circleIndex, ref Dictionary<int, int> materialDict, ref bool isNeedAwake)
		{
			return default(bool);
		}

		private void AddLimitBreakPieceNeedMaterial(GrowthManaCircleModel model, int circleIndex, ref Dictionary<int, int> materialDict)
		{
		}

		public int GetMinGrowMaterialCount()
		{
			return default(int);
		}

		private int GetNeedDewByPieceData(GrowthManaCircleModel model, GrowthManaCircleManaPieceData pieceData, ref int exAbilityLevel)
		{
			return default(int);
		}
	}
}
