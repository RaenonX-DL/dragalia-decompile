using System.Runtime.CompilerServices;

namespace Gluon
{
	public class CameraModeBase
	{
		protected int cameraStep;

		protected float cameraTime;

		protected CameraController camera
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CameraModeBase(CameraController controller)
		{
		}

		public void Initialize()
		{
		}

		public virtual void Update()
		{
		}
	}
}
