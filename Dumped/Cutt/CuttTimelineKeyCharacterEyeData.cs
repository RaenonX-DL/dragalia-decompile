using System;
using Gluon;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCharacterEyeData : CuttTimelineKey
	{
		public CuttCharacterFaceAnimation.ModelType modelType;

		public CuttCharaEye expressionType;

		public CharaFaceEye normalFaceType;

		public CuttCharacterFaceAnimation.Type animationType;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}
	}
}
