using System.Runtime.CompilerServices;

namespace Gluon
{
	public class ProductionBase
	{
		protected CharacterManager charaManager;

		protected CameraController cameraController;

		protected InGameUICtrl uiCtrl;

		protected float time;

		protected float enableSkipTime;

		public bool skip
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

		protected void SetEnableSkipTime(float t)
		{
		}

		public virtual bool Update()
		{
			return default(bool);
		}

		public static void ChangeAttachWeaponForKAT(CharacterBase chara, string state, float frameStart = 0f, float frameEnd = 0f, bool forceLeft = false)
		{
		}
	}
}
