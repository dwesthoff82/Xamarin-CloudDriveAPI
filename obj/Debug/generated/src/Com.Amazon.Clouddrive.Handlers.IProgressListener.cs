using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Handlers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.clouddrive.handlers']/interface[@name='ProgressListener']"
	[Register ("com/amazon/clouddrive/handlers/ProgressListener", "", "Com.Amazon.Clouddrive.Handlers.IProgressListenerInvoker")]
	public partial interface IProgressListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.handlers']/interface[@name='ProgressListener']/method[@name='onProgress' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("onProgress", "(JJ)V", "GetOnProgress_JJHandler:Com.Amazon.Clouddrive.Handlers.IProgressListenerInvoker, CloudDriveAPI")]
		void OnProgress (long p0, long p1);

	}

	[global::Android.Runtime.Register ("com/amazon/clouddrive/handlers/ProgressListener", DoNotGenerateAcw=true)]
	internal class IProgressListenerInvoker : global::Java.Lang.Object, IProgressListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/clouddrive/handlers/ProgressListener");
		IntPtr class_ref;

		public static IProgressListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProgressListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.clouddrive.handlers.ProgressListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProgressListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IProgressListenerInvoker); }
		}

		static Delegate cb_onProgress_JJ;
#pragma warning disable 0169
		static Delegate GetOnProgress_JJHandler ()
		{
			if (cb_onProgress_JJ == null)
				cb_onProgress_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_OnProgress_JJ);
			return cb_onProgress_JJ;
		}

		static void n_OnProgress_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Amazon.Clouddrive.Handlers.IProgressListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IProgressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnProgress (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onProgress_JJ;
		public unsafe void OnProgress (long p0, long p1)
		{
			if (id_onProgress_JJ == IntPtr.Zero)
				id_onProgress_JJ = JNIEnv.GetMethodID (class_ref, "onProgress", "(JJ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onProgress_JJ, __args);
		}

	}

	public partial class ProgressEventArgs : global::System.EventArgs {

		public ProgressEventArgs (long p0, long p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		long p0;
		public long P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/amazon/clouddrive/handlers/ProgressListenerImplementor")]
	internal sealed partial class IProgressListenerImplementor : global::Java.Lang.Object, IProgressListener {

		object sender;

		public IProgressListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amazon/clouddrive/handlers/ProgressListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ProgressEventArgs> Handler;
#pragma warning restore 0649

		public void OnProgress (long p0, long p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ProgressEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IProgressListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
