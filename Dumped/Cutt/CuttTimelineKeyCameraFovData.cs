using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCameraFovData : CuttTimelineKeyWithInterpolate
	{
		public CuttCameraFovType fovType;

		public float fov;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);
	}
}
