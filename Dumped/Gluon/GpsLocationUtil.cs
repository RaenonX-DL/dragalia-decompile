using System;
using System.Collections;

namespace Gluon
{
	public static class GpsLocationUtil
	{
		public static bool IsEnabledByUser => default(bool);

		public static float Latitude => default(float);

		public static float Longitude => default(float);

		public static IEnumerator GetLocationInfoCoroutine(float waitMaxTime, Action onSucceess, Action onError)
		{
			return null;
		}

		public static IEnumerator RequestLocationPermission(Action onPermitted, Action onDenied)
		{
			return null;
		}
	}
}
