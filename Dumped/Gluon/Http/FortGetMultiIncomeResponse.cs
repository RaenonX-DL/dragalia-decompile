namespace Gluon.Http
{
	public class FortGetMultiIncomeResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public AtgenHarvestBuildList[] harvest_build_list;

			public AtgenAddCoinList[] add_coin_list;

			public AtgenAddStaminaList[] add_stamina_list;

			public int is_over_coin;

			public int is_over_material;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
