/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;
using NPF;

// Image 52: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.MyNintendo
{
	public class PointProgramService
	{
		// Nested types
		public interface IEventCallback
		{
			// Methods
			void OnAppeared(PointProgramService pointProgramService);
			void OnHide(PointProgramService pointProgramService);
			void OnNintendoAccountLogin(PointProgramService pointProgramService);
			void OnDismiss(NPFError error);
		}
	}
}
