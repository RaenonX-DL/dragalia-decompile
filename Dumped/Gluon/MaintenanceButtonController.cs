using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	[DisallowMultipleComponent]
	public class MaintenanceButtonController : MonoBehaviour
	{
		[SerializeField]
		public List<MaintenanceFunctionType> funcTypes;

		[SerializeField]
		private GameObject addingObj;

		[SerializeField]
		public bool isGrayout;

		[SerializeField]
		public bool isAddDisabledColor;

		[SerializeField]
		private Color disabledColor;

		[SerializeField]
		private float addingObjScale;

		private Selectable.Transition tempTransition;

		private static readonly Dictionary<MaintenanceFunctionType, SystemMessage> maintenanceMessageDict;

		public bool isInMaintenance
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetAddingObj(GameObject obj)
		{
		}

		public void AttachMaintenancePUHandler(PointerEventHandler eventHandler)
		{
		}

		private void OnDestroy()
		{
		}

		public void UpdateEnableState(bool needUpdateWhenNotInMaintenanse = false, [Optional] List<MaintenanceFunctionType> withSwitchFuncTypes, bool keepInteractableIsFalse = false)
		{
		}

		public void ShowMaintenanceError()
		{
		}

		public static bool ShowMaintenanceError(MaintenanceFunctionType funcType)
		{
			return default(bool);
		}

		public static bool ShowMaintenanceError(List<MaintenanceFunctionType> funcTypes)
		{
			return default(bool);
		}
	}
}
