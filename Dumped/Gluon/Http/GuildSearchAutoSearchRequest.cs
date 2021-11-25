using Cute.Http;

namespace Gluon.Http
{
	public class GuildSearchAutoSearchRequest : RequestCommon
	{
		public int[] joining_condition_type_list;

		public int[] activity_policy_type_list;

		public int[] member_count_type_list;
	}
}
