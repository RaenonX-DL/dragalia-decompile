using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlMultiPrefabComponent : MonoBehaviour
	{
		[SerializeField]
		private bool _editMode;

		[SerializeField]
		private List<FlMultiPrefabItem> _prefabItemList;

		private List<GameObject> _childObjectList;

		private bool _editFromObject;

		public List<FlMultiPrefabItem> PrefabItemList => null;

		private void OnValidate()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void Awake()
		{
		}

		private void CreateInstanceObject()
		{
		}

		private void UpdateInstanceObject()
		{
		}

		private void ClearChildObject()
		{
		}
	}
}
