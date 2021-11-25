using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponTypeBonusSeriesCell : MonoBehaviour
	{
		public Text seriesTitle;

		public Transform cellParentTransform;

		public GameObject originCell;

		[HideInInspector]
		public int seriesIndex;

		public void InitCell(int seriesIndex)
		{
		}

		public void AddCell(int weaponId)
		{
		}
	}
}
