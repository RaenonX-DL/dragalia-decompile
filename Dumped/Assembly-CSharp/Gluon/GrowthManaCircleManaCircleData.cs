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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public CharaDataElement masterCharaData;
			public GrowthManaCircleManaCircleData __4__this;
			public int pieceElementGroupId;
	
			// Constructors
			public __c__DisplayClass21_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_1
		{
			// Fields
			public List<MCElement> list;
			public __c__DisplayClass21_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass21_1();
	
			// Methods
			internal void _Init_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<GrowthManaCircleManaPieceData> __9__29_0;
			public static Comparison<GrowthManaCircleManaPieceData> __9__29_1;
			public static Comparison<GrowthManaCircleManaPieceData> __9__30_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _GetAutoReleasablePointList_b__29_0(GrowthManaCircleManaPieceData a, GrowthManaCircleManaPieceData b);
			internal int _GetAutoReleasablePointList_b__29_1(GrowthManaCircleManaPieceData a, GrowthManaCircleManaPieceData b);
			internal int _GetAutoReleasablePointListGrowMaterial_b__30_0(GrowthManaCircleManaPieceData a, GrowthManaCircleManaPieceData b);
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
		public int GetMinGrowMaterialCount();
	}
}
