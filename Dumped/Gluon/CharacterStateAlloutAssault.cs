namespace Gluon
{
	public class CharacterStateAlloutAssault : CharacterStateBase
	{
		private const string EFFECT_NAME = "EFF_EIG_003";

		private EffectObject _effectObject;

		public bool isStateEffect
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		protected override void OnStateEnter_Internal()
		{
		}

		public override void OnStateExit()
		{
		}

		public override void OnDisconnectOwner()
		{
		}

		private void SetMeshVisibility(bool visibility)
		{
		}
	}
}
