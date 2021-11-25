using System.Runtime.CompilerServices;
using Gluon.PostEffectParams;

namespace Cutt
{
	public class CuttTimelineDofCtrl
	{
		private CuttTimelineKeyDofCtrlDataList _keys;

		public bool isEnableDof
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

		public DofFocalType dofFocalType
		{
			[CompilerGenerated]
			get
			{
				return default(DofFocalType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float focalSize
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

		public float focalLength
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

		public float smoothness
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

		public float smoothStepMin
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

		public float smoothStepMax
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

		public void Initialize(CuttTimelineKeyDofCtrlDataList keys, CuttTimelineControl timelineControl)
		{
		}

		public void AlterUpdate(float currentTime, float targetFps, int currentFrame)
		{
		}
	}
}
