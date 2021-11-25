using System;
using UnityEngine;

public class CriAfxMcDspInitializer : MonoBehaviour
{
	private const string scriptVersionString = "1.00.00";

	private const int scriptVersionNumber = 16777216;

	public const string pluginName = "criafx_mcdsp";

	private void Awake()
	{
	}

	public static void AddInterfaces()
	{
	}

	private static extern IntPtr criAfxMcDSPAE600_GetInterfaceWithVersion();

	private static extern IntPtr criAfxMcDSPFutzBox_GetInterfaceWithVersion();

	private static extern IntPtr criAfxMcDSPML4000ML1_GetInterfaceWithVersion();

	private static extern IntPtr criAfxMcDSPSA2_GetInterfaceWithVersion();
}
