/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Runtime.CompilerServices;
using NPF.Internal.Mapper;
using NPF.User;

// Image 49: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Domain.Service
{
	internal class LinkedAccountBridgeService
	{
		// Nested types
		public class Apple : LinkedAccountService
		{
			// Fields
			private readonly LinkedAccountBridgeMapper _linkedAccountBridgeMapper;
	
			// Constructors
			public Apple();
		}
	
		public class Google : LinkedAccountService
		{
			// Fields
			private readonly LinkedAccountBridgeMapper _linkedAccountBridgeMapper;
	
			// Constructors
			public Google();
		}
	
		public class Facebook : LinkedAccountService
		{
			// Fields
			private readonly LinkedAccountBridgeMapper _linkedAccountBridgeMapper;
	
			// Constructors
			public Facebook();
		}
	}
}
