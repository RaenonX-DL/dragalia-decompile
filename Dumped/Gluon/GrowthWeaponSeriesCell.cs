using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponSeriesCell : MonoBehaviour
	{
		public Image seriesImage;

		public Badge badgeIcon;

		public Action<int> cellPressCallBack;

		public GameObject blackMaskObject;

		public GameObject lockIconObject;

		private int cellIndex;

		private int seriesLockType;

		private string conditionString;

		private const int originSeriesId = 1;

		private const int kimairaSeriesId = 5;

		private const int shinDragonSeriesId = 3;

		public void InitCell(int index)
		{
		}

		public void UpdateCell()
		{
		}

		public void OnCellPressed()
		{
		}

		public void SetTutorialLock()
		{
		}

		private bool IsClearLockCondition(int lockType)
		{
			return default(bool);
		}
	}
}
