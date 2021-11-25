public class CriFsWebInstallRequest : CriFsInstallRequest
{
	private CriFsWebInstaller installer;

	private uint crc32;

	private bool crc32_set;

	public override void Stop()
	{
	}

	public bool GetCRC32(out uint ret_val)
	{
		return default(bool);
	}

	public CriFsWebInstallRequest(string srcPath, string dstPath, DoneDelegate doneDelegate)
	{
	}

	public override void Update()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
