using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class GrowthWeaponSeriesListCanvas : MonoBehaviour
	{
		public Transform cellParentTransform;

		public DragEventScrollRect scrollRect;

		[HideInInspector]
		public GrowthWeaponScene scene;

		private List<GrowthWeaponSeriesCell> weaponSeriesCells;

		private void Start()
		{
		}

		public void LoadList()
		{
		}

		public void UpdateListCanvas()
		{
		}

		public void OnSeriesCellPressed(int index)
		{
		}

		private void SetWeaponTutorial()
		{
		}
	}
}
