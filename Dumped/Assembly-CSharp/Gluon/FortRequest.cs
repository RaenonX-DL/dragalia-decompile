/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class FortRequest
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public Action onSuccess;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal void _RequestFortInfo_b__0(FortGetDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0
		{
			// Fields
			public Action<DragonGetContactDataResponse> onSuccess;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _RequestDragonGetContactData_b__0(DragonGetContactDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0
		{
			// Fields
			public Action<Facility> onSuccess;
			public Facility facility;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal void _RequestStartToBuild_b__0(FortBuildStartResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public bool isFromStoreHouse;
			public Facility facility;
			public Action<Facility> onSuccess;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _RequestMoveFacility_b__0(FortMoveResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public Action onSuccess;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal void _RequestCompleteBuilding_b__0(FortBuildEndResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public Action onSuccess;
			public Facility facilityModel;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _RequestStartLevelUp_b__0(FortLevelupStartResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public Action onSuccess;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _RequestCompleteLevelUp_b__0(FortLevelupEndResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public Action onSuccess;
			public Facility facilityModel;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _RequestCompleteAtOnce_b__0(FortBuildAtOnceResponse response);
			internal void _RequestCompleteAtOnce_b__1(FortLevelupAtOnceResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public Action onSuccess;
			public Facility facilityModel;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _RequestCancel_b__0(FortBuildCancelResponse response);
			internal void _RequestCancel_b__1(FortLevelupCancelResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public FacilityViewController facilityVC;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _RequestGetInCome_b__0(FortGetMultiIncomeResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public List<FacilityViewController> facilityVcList;
			public int num;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _RequestGetInComeList_b__0(FortGetMultiIncomeResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public FortViewController viewCtrl;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _RequestAddSmith_b__0(FortAddCarpenterResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public Action onSuccess;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _RequestClearFacilityNewFlag_b__0(FortSetNewFortPlantResponse response);
		}
	
		// Methods
		public static void RequestFortInfo(Action onSuccess);
		public static void RequestDragonGetContactData(Action<DragonGetContactDataResponse> onSuccess);
		public static void RequestStartToBuild(Facility facility, Vector2 gridPos, Action<Facility> onSuccess = null);
		public static void RequestMoveFacility(Facility facility, int gridPosX, int gridPosY, bool isFromStoreHouse = false, Action<Facility> onSuccess = null);
		public static void RequestCompleteBuilding(Facility facilityModel, Action onSuccess = null);
		public static void RequestStartLevelUp(Facility facilityModel, ulong buildId, Action onSuccess = null);
		public static void RequestCompleteLevelUp(Facility facilityModel, Action onSuccess = null);
		public static void RequestCompleteAtOnce(Facility.eFacilityStatus status, Facility facilityModel, PaymentType type, Action onSuccess = null);
		public static void RequestCancel(Facility facilityModel, Action onSuccess = null);
		public static void RequestGetInCome(FacilityViewController facilityVC);
		public static void RequestGetInComeList(List<FacilityViewController> facilityVcList);
		public static void RequestAddSmith(int costStone, FortViewController viewCtrl, PaymentType type);
		public static void RequestClearFacilityNewFlag(List<int> fortPlantIdList, Action onSuccess);
	}
}
