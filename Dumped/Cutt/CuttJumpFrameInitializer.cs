using System.Collections.Generic;
using UnityEngine;

namespace Cutt
{
	public class CuttJumpFrameInitializer : MonoBehaviour
	{
		[SerializeField]
		private List<CuttJumpFrameData> jumpFrameDataList;

		public static CuttJumpFrameInitializer instance;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public List<CuttJumpFrameData> GetJumpFrameList()
		{
			return null;
		}

		public CuttJumpFrameData GetJumpData(int jumpId)
		{
			return null;
		}
	}
}
