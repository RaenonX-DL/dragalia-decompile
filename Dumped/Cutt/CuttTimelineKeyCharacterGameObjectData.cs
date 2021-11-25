using System;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCharacterGameObjectData : CuttTimelineKey
	{
		private static readonly int targetDataArrayNum;

		[HideInInspector]
		public bool[] targetDataArray;

		private CuttCharacterController targetCharaCtrl;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}

		public void Initialize(CuttCharacterController charaCtrl)
		{
		}

		public void UpdateActiveFlag(CuttCharacterController charaCtrl)
		{
		}

		private Transform GetNode(Transform rootNode, string nodeName)
		{
			return null;
		}
	}
}
