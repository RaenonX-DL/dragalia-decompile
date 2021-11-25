using System.Runtime.CompilerServices;

namespace Cutt
{
	public class CuttTimelinePostEffect
	{
		private CuttTimelineKeyPostEffectDataList _keys;

		public bool isEnableDiffusionColor
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float blurSize
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Initialize(CuttTimelineKeyPostEffectDataList keys, CuttTimelineControl timelineControl)
		{
		}

		public void AlterUpdate(float currentTime, float targetFps, int currentFrame)
		{
		}
	}
}
