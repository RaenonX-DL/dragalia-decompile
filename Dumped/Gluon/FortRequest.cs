using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public static class FortRequest
	{
		public static void RequestFortInfo(Action onSuccess)
		{
		}

		public static void RequestDragonGetContactData(Action<DragonGetContactDataResponse> onSuccess)
		{
		}

		public static void RequestStartToBuild(Facility facility, Vector2 gridPos, [Optional] Action<Facility> onSuccess)
		{
		}

		public static void RequestMoveFacility(Facility facility, int gridPosX, int gridPosY, bool isFromStoreHouse = false, [Optional] Action<Facility> onSuccess)
		{
		}

		public static void RequestCompleteBuilding(Facility facilityModel, [Optional] Action onSuccess)
		{
		}

		public static void RequestStartLevelUp(Facility facilityModel, ulong buildId, [Optional] Action onSuccess)
		{
		}

		public static void RequestCompleteLevelUp(Facility facilityModel, [Optional] Action onSuccess)
		{
		}

		public static void RequestCompleteAtOnce(Facility.eFacilityStatus status, Facility facilityModel, PaymentType type, [Optional] Action onSuccess)
		{
		}

		public static void RequestCancel(Facility facilityModel, [Optional] Action onSuccess)
		{
		}

		public static void RequestGetInCome(FacilityViewController facilityVC)
		{
		}

		public static void RequestGetInComeList(List<FacilityViewController> facilityVcList)
		{
		}

		public static void RequestAddSmith(int costStone, FortViewController viewCtrl, PaymentType type)
		{
		}

		public static void RequestClearFacilityNewFlag(List<int> fortPlantIdList, Action onSuccess)
		{
		}
	}
}
