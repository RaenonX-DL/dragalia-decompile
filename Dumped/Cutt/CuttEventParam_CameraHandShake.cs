using System;

namespace Cutt
{
	[Serializable]
	public class CuttEventParam_CameraHandShake : CuttEventParamBase
	{
		public bool isEnable;

		public bool isOverwrite;

		public float positionAmount;

		public float rotationAmount;

		public CuttEventVec3Data positionComponents;

		public CuttEventVec3Data rotationComponents;
	}
}
