namespace Gluon.Http
{
	public class AtgenBoxSummonResult
	{
		public int event_id;

		public int box_summon_seq;

		public int reset_possible;

		public int remaining_quantity;

		public int max_exec_count;

		public int is_stopped_by_target;

		public AtgenDrawDetails[] draw_details;

		public AtgenBoxSummonDetail[] box_summon_detail;

		public int event_point;
	}
}
