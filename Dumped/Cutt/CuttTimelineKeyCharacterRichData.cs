using System;
using Gluon;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCharacterRichData : CuttTimelineKeyWithInterpolate
	{
		private CuttCharacterController targetCharaCtrl;

		private RichModelController richModelController;

		public float outlineWidth;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override bool IsInterpolateKey()
		{
			return default(bool);
		}

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}

		public void Initialize(CuttCharacterController charaCtrl)
		{
		}

		public void SetData(CuttTimelineKeyCharacterRichData srcData)
		{
		}

		public void Lerp(CuttTimelineKeyCharacterRichData a, CuttTimelineKeyCharacterRichData b, float ratio)
		{
		}

		public void UpdateData()
		{
		}
	}
}
