/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleManaCircleData : MonoBehaviour
	{
		// Fields
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
	
		// Nested types
		private class CircleDataList<T>
		{
			// Fields
			public List<T> circleData;
	
			// Constructors
			public CircleDataList(GrowthManaCircleManaCircleData self, List<T> list, CharaList charaData, Action action);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public CharaDataElement masterCharaData;
			public GrowthManaCircleManaCircleData __4__this;
			public int pieceElementGroupId;
	
			// Constructors
			public __c__DisplayClass25_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_1
		{
			// Fields
			public List<MCElement> list;
			public __c__DisplayClass25_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass25_1();
	
			// Methods
			internal void _Init_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<GrowthManaCircleManaPieceData> __9__33_0;
			public static Comparison<GrowthManaCircleManaPieceData> __9__33_1;
			public static Comparison<GrowthManaCircleManaPieceData> __9__34_0;
			public static Func<GrowthManaCircleManaPieceData, int> __9__35_0;
			public static Func<GrowthManaCircleManaPieceData, int> __9__35_1;
			public static Func<GrowthManaCircleManaPieceData, int> __9__36_0;
			public static Func<GrowthManaCircleManaPieceData, int> __9__36_1;
			public static Func<GrowthManaCircleManaPieceData, int> __9__38_0;
			public static Func<GrowthManaCircleManaPieceData, int> __9__38_1;
			public static Func<GrowthManaCircleManaPieceData, int> __9__41_0;
			public static Func<GrowthManaCircleManaPieceData, int> __9__41_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _GetAutoReleasablePointList_b__33_0(GrowthManaCircleManaPieceData a, GrowthManaCircleManaPieceData b);
			internal int _GetAutoReleasablePointList_b__33_1(GrowthManaCircleManaPieceData a, GrowthManaCircleManaPieceData b);
			internal int _GetAutoReleasablePointListGrowMaterial_b__34_0(GrowthManaCircleManaPieceData a, GrowthManaCircleManaPieceData b);
			internal int _GetAutoReleasableSecondManaCirclePointListGrowMaterial_b__35_0(GrowthManaCircleManaPieceData p);
			internal int _GetAutoReleasableSecondManaCirclePointListGrowMaterial_b__35_1(GrowthManaCircleManaPieceData p);
			internal int _GetReleaseSecondCirclePointDatasByPieceData_b__36_0(GrowthManaCircleManaPieceData p);
			internal int _GetReleaseSecondCirclePointDatasByPieceData_b__36_1(GrowthManaCircleManaPieceData p);
			internal int _GetAutoReleasableAllCirclePointDatas_b__38_0(GrowthManaCircleManaPieceData p);
			internal int _GetAutoReleasableAllCirclePointDatas_b__38_1(GrowthManaCircleManaPieceData p);
			internal int _GetReleaseCirclePointDatasByCirclePoints_b__41_0(GrowthManaCircleManaPieceData p);
			internal int _GetReleaseCirclePointDatasByCirclePoints_b__41_1(GrowthManaCircleManaPieceData p);
		}
	
		// Constructors
		public GrowthManaCircleManaCircleData();
	
		// Methods
		private void CreatePropertyCopyArray(int count);
		public void Init(string circleName, CharaList charaData);
		private int SetPieceDataWithMaterial(int index, int pieceElementGroupId, ManaPieceType type, ref int level, ref int step);
		private int SetPieceDataWithGrowMaterial(int index, int pieceElementGroupId, ManaPieceType type, ref int level, ref int step, int growId, int growNum);
		public GrowthManaCircleManaPieceData GetPieceData(int circleIndex, int pieceIndex);
		public GrowthManaCircleManaPieceData GetPieceData(int dataListIndex);
		public void ReleaseManaPiece(int circleIndex, int pieceIndex);
		public void ReleaseManaPiece(int dataListIndex);
		public bool IsManaPieceReleased(int circleIndex, int pieceIndex);
		public List<GrowthManaCircleManaPieceData> GetAutoReleasablePointList(int circleIndex, int currentMP, out int requiredMP, out int requiredDew, out bool isMaterialsufficient);
		public List<GrowthManaCircleManaPieceData> GetAutoReleasablePointListGrowMaterial(int circleIndex);
		public AutoReleasableAllCirclePointData GetAutoReleasableSecondManaCirclePointListGrowMaterial();
		public AutoReleasableAllCirclePointData GetReleaseSecondCirclePointDatasByPieceData(GrowthManaCircleModel model, GrowthManaCircleManaPieceData pieceData);
		public AutoReleasableAllCirclePointData GetAutoReleasableFirstCirclePointList(GrowthManaCircleModel model, int circleIndex);
		private AutoReleasableAllCirclePointData GetAutoReleasableAllCirclePointDatas(GrowthManaCircleModel model, GrowthManaCircleManaPieceData[] circlePoints, bool isUseGrowMaterial);
		public AutoReleasableAllCirclePointData GetReleaseFirstCirclePointDatasByCircleIndex(GrowthManaCircleModel model, int circleIndex, int targetCircleIndex);
		public AutoReleasableAllCirclePointData GetReleaseFirstCirclePointDatasByPieceData(GrowthManaCircleModel model, int circleIndex, GrowthManaCircleManaPieceData pieceData);
		private AutoReleasableAllCirclePointData GetReleaseCirclePointDatasByCirclePoints(GrowthManaCircleModel model, GrowthManaCircleManaPieceData[] circlePoints, bool isUseGrowMaterial, bool isAddLimitBreakPiece = false);
		private bool IsReleasableLimitBreakPiece(GrowthManaCircleModel model, int circleIndex, ref Dictionary<int, int> materialDict, ref bool isNeedAwake);
		private void AddLimitBreakPieceNeedMaterial(GrowthManaCircleModel model, int circleIndex, ref Dictionary<int, int> materialDict);
		public int GetMinGrowMaterialCount();
	}
}
