using Cute.Http;

namespace Gluon.Http
{
	public class FortMoveRequest : RequestCommon
	{
		public ulong build_id;

		public int after_position_x;

		public int after_position_z;
	}
}
