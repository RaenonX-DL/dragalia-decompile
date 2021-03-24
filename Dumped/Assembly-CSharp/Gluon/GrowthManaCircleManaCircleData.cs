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
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _GetAutoReleasablePointList_b__33_0(GrowthManaCircleManaPieceData a, GrowthManaCircleManaPieceData b);
			internal int _GetAutoReleasablePointList_b__33_1(GrowthManaCircleManaPieceData a, GrowthManaCircleManaPieceData b);
			internal int _GetAutoReleasablePointListGrowMaterial_b__34_0(GrowthManaCircleManaPieceData a, GrowthManaCircleManaPieceData b);
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
		public List<GrowthManaCircleManaPieceData> GetAutoReleasableSecondManaCirclePointListGrowMaterial(out int requiredMP, out int requiredDew, out bool isMaterialsufficient);
		public int GetMinGrowMaterialCount();
	}
}
