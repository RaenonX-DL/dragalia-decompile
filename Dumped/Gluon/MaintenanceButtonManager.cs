using System.Collections.Generic;

namespace Gluon
{
	public class MaintenanceButtonManager : SingletonMonoBehaviour<MaintenanceButtonManager>
	{
		private List<MaintenanceButtonController> controllers;

		private List<MaintenanceFunctionType> currentFunctionalMaintenanceList;

		protected override void Awake()
		{
		}

		public void Register(MaintenanceButtonController controller)
		{
		}

		public void UnRegister(MaintenanceButtonController controller)
		{
		}

		public void UnRegisterAll()
		{
		}

		public void UpdateEnableState()
		{
		}

		public static bool IsInMaintenance(List<MaintenanceFunctionType> funcTypes)
		{
			return default(bool);
		}

		public static bool IsInMaintenance(MaintenanceFunctionType funcType)
		{
			return default(bool);
		}

		public static SystemMessage GetMaintenanceResultCodeByFunctionType(MaintenanceFunctionType type)
		{
			return default(SystemMessage);
		}

		public static bool IsMaintenanceResultCode(int n)
		{
			return default(bool);
		}
	}
}
