package md54ec764bdb5235a0b78fe6b118f6907b9;


public class ChanDoanBenhActivity
	extends android.app.ListActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("DoraemonCare_mother_of_final.ChanDoanBenhActivity, DoraemonCare_mother_of_final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ChanDoanBenhActivity.class, __md_methods);
	}


	public ChanDoanBenhActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ChanDoanBenhActivity.class)
			mono.android.TypeManager.Activate ("DoraemonCare_mother_of_final.ChanDoanBenhActivity, DoraemonCare_mother_of_final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
