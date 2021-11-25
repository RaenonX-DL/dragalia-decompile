using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class FortCharaArrangePlace : MonoBehaviour
	{
		[SerializeField]
		private FortCharaArrangeController.PlaceType type;

		[SerializeField]
		private GameObject[] arrangePointList;

		[SerializeField]
		private GameObject[] moveTargetPointList;

		private List<GameObject> targetArrangedCharaList;

		private List<GameObject> tempObjList;

		public FortCharaArrangeController.PlaceType placeType => default(FortCharaArrangeController.PlaceType);

		public GameObject arrangedChara
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Start()
		{
		}

		public int GetArrangePointNum()
		{
			return default(int);
		}

		public GameObject GetArrangePoint(int index)
		{
			return null;
		}

		public int GetMoveTargetPointNum()
		{
			return default(int);
		}

		public GameObject GetMoveTargetPoint(int index)
		{
			return null;
		}

		public void SetMoveTargetPoint(int index, GameObject chara)
		{
		}

		public int SetMoveTargetPoint(GameObject target, GameObject chara)
		{
			return default(int);
		}

		public GameObject GetVacantRandomMoveTargetPoint(out int index)
		{
			return null;
		}

		public void GetVacantMoveTargetPointList(List<GameObject> targetPointList)
		{
		}
	}
}
