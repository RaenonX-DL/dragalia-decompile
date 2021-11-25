using NPF.User;

namespace Gluon
{
	public class NPFBaaSUserWrapper
	{
		private const string NA_KEY = "nintendoAccount";

		public static bool IsCountryCodeAvailable(string countryCode)
		{
			return default(bool);
		}

		public static string GetIDToken()
		{
			return null;
		}

		public static bool IsNALinked()
		{
			return default(bool);
		}

		public static NintendoAccount GetLinkedNA()
		{
			return null;
		}

		public static string GetLinkedNACountryCode()
		{
			return null;
		}

		public static int GetAge()
		{
			return default(int);
		}

		public static bool IsNOECountry(string locationCode)
		{
			return default(bool);
		}

		public static bool IsNALCountry(string locationCode)
		{
			return default(bool);
		}

		public static bool IsNOACountry(string locationCode)
		{
			return default(bool);
		}
	}
}
