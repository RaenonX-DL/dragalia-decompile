namespace Gluon
{
	public class PlayerGuardReactionInChargeController
	{
		private bool isWait;

		private float[] damageCutRate;

		private int[] actionId;

		private PlayerCharacter player;

		public PlayerGuardReactionInChargeController(PlayerCharacter player)
		{
		}

		public void Reset()
		{
		}

		public bool IsWait()
		{
			return default(bool);
		}

		public void StartWait(float[] rate, int[] ids)
		{
		}

		public void StopWait()
		{
		}

		public float GetDamageCutRateOnWait(int invincibleBreakLv)
		{
			return default(float);
		}

		public int GetActionIdOnWait(int invincibleBreakLv)
		{
			return default(int);
		}

		public void Exec(int invincibleBreakLv)
		{
		}
	}
}
