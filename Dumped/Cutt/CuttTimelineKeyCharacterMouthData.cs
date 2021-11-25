using System;
using Gluon;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCharacterMouthData : CuttTimelineKey
	{
		public CuttCharacterFaceAnimation.ModelType modelType;

		public CuttCharaMouth expressionType;

		public CharaFaceMouth normalFaceType;

		public CuttCharacterFaceAnimation.Type animationType;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}
	}
}
