namespace Gluon.Http
{
	public class EventDamageReceiveDamageRewardResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenEventDamageRewardList[] event_damage_reward_list;
		}

		public CommonResponse data;
	}
}
