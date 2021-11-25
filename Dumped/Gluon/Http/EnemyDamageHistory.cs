using System.Runtime.InteropServices;

namespace Gluon.Http
{
	[StructLayout(0, Size = 16)]
	public struct EnemyDamageHistory
	{
		public int[] damage;

		public int[] combo;
	}
}
