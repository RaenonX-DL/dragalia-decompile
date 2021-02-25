/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NPF;

// Image 49: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Promo
{
	public static class PromoCode
	{
		// Nested types
		public interface IPromoCodeEventHandler
		{
			// Methods
			void OnPromotionNotificationSuccess(IList<PromoCodeBundle> promotionNotificationBundleList);
			void OnOthersNotificationSuccess(IList<PromoCodeBundle> othersNotificationBundleList);
			void OnPromotionNotoficationError(NPFError error);
		}
	}
}
