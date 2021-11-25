using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BuildEventInfoCtrl : EventInfoCtrlBase
	{
		[SerializeField]
		private Text[] materialTexts;

		[SerializeField]
		private Image[] materialIcons;

		[SerializeField]
		private Text buildLevel;

		[SerializeField]
		private Text facilityDescription;

		[SerializeField]
		private Text noFacilityDescription;

		[SerializeField]
		private Text facilityTitle;

		[SerializeField]
		private CommonIcon buildIcon;

		private int fortPlantId;

		private int fortPlantLevel;

		public static BuildEventInfoCtrl Create(Transform parent)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public static BuildList GetBuildPlantData(int eventId)
		{
			return null;
		}

		public override void SetEventInfo()
		{
		}

		public void OnButtonDetailTouched()
		{
		}
	}
}
