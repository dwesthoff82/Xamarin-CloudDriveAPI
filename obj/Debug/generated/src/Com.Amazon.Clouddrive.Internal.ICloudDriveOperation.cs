using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.clouddrive.internal']/interface[@name='CloudDriveOperation']"
	[Register ("com/amazon/clouddrive/internal/CloudDriveOperation", "", "Com.Amazon.Clouddrive.Internal.ICloudDriveOperationInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Response"})]
	public partial interface ICloudDriveOperation : global::Java.Util.Concurrent.ICallable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal']/interface[@name='CloudDriveOperation']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/lang/Object;", "GetCallHandler:Com.Amazon.Clouddrive.Internal.ICloudDriveOperationInvoker, CloudDriveAPI")]
		global::Java.Lang.Object Call ();

	}

	[global::Android.Runtime.Register ("com/amazon/clouddrive/internal/CloudDriveOperation", DoNotGenerateAcw=true)]
	internal class ICloudDriveOperationInvoker : global::Java.Lang.Object, ICloudDriveOperation {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/clouddrive/internal/CloudDriveOperation");
		IntPtr class_ref;

		public static ICloudDriveOperation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICloudDriveOperation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.clouddrive.internal.CloudDriveOperation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICloudDriveOperationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICloudDriveOperationInvoker); }
		}

		static Delegate cb_call;
#pragma warning disable 0169
		static Delegate GetCallHandler ()
		{
			if (cb_call == null)
				cb_call = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Call);
			return cb_call;
		}

		static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		IntPtr id_call;
		public unsafe global::Java.Lang.Object Call ()
		{
			if (id_call == IntPtr.Zero)
				id_call = JNIEnv.GetMethodID (class_ref, "call", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_call), JniHandleOwnership.TransferLocalRef);
		}

	}

}
