using Cute.Http;

namespace Gluon.Http
{
	public class ExchangeSelectUnitRequest : RequestCommon
	{
		public int exchange_ticket_id;

		public AtgenDuplicateEntityList selected_unit;
	}
}
