/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortCharaArrangePlace : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private FortCharaArrangeController.PlaceType type;
		[SerializeField]
		private GameObject[] arrangePointList;
		[SerializeField]
		private GameObject[] moveTargetPointList;
		private List<GameObject> targetArrangedCharaList;
		private List<GameObject> tempObjList;
		[CompilerGenerated]
		private GameObject _arrangedChara_k__BackingField;
	
		// Properties
		public FortCharaArrangeController.PlaceType placeType { get; }
		public GameObject arrangedChara { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public FortCharaArrangePlace();
	
		// Methods
		private void Start();
		public int GetArrangePointNum();
		public GameObject GetArrangePoint(int index);
		public int GetMoveTargetPointNum();
		public GameObject GetMoveTargetPoint(int index);
		public void SetMoveTargetPoint(int index, GameObject chara);
		public int SetMoveTargetPoint(GameObject target, GameObject chara);
		public GameObject GetVacantRandomMoveTargetPoint(out int index);
		public void GetVacantMoveTargetPointList(List<GameObject> targetPointList);
	}
}
