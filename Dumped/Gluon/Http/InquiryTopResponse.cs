namespace Gluon.Http
{
	public class InquiryTopResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenOpinionList[] opinion_list;

			public AtgenOpinionTypeList[] opinion_type_list;

			public AtgenInquiryFaqList[] inquiry_faq_list;
		}

		public CommonResponse data;
	}
}
