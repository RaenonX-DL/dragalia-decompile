using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthBaseSelectListBase : CommonIconListBase
	{
		public GrowthBaseSelectListController listController;

		public TabBase listTab;

		public GameObject awakeBase;

		public Text awakeText;

		public GameObject listSpace;

		public GameObject effectBaseObject;

		public UnityAction listChangeButtonCallBack;

		public GameObject listButtonObj;

		public UnityAction resetPlusButtonCallBack;

		public GameObject resetButtonObj;

		public Text resetButtonText;

		public bool isReleaseResetPlus;

		public MaintenanceButtonController resetButtonMainte;

		public GameObject searchSpaceObject;

		public Button crestInfoButton;

		public Text crestInfoButtonText;

		public void InitListBase()
		{
		}

		public void OnListChangeButtonPressed()
		{
		}

		public void OnResetPlusButtonPressed()
		{
		}

		public void ChangeTabText(bool isResetPlus)
		{
		}

		public void OnCresetInfoChangeButtonPressed()
		{
		}
	}
}
