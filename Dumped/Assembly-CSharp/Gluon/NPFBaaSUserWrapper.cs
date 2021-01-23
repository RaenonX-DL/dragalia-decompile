/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NPF.User;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class NPFBaaSUserWrapper
	{
		// Constructors
		public NPFBaaSUserWrapper();
	
		// Methods
		public static bool IsCountryCodeAvailable(string countryCode);
		public static string GetIDToken();
		public static bool IsNALinked();
		public static NintendoAccount GetLinkedNA();
		public static string GetLinkedNACountryCode();
		public static int GetAge();
		public static bool IsNOECountry(string locationCode);
		public static bool IsNALCountry(string locationCode);
		public static bool IsNOACountry(string locationCode);
	}
}
