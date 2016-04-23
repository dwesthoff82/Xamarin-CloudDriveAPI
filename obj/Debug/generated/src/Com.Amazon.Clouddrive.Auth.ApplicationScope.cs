using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.auth']/class[@name='ApplicationScope']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/auth/ApplicationScope", DoNotGenerateAcw=true)]
	public partial class ApplicationScope : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.auth']/class[@name='ApplicationScope']/field[@name='CLOUDDRIVE_READ']"
		[Register ("CLOUDDRIVE_READ")]
		public const string ClouddriveRead = (string) "clouddrive:read";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.auth']/class[@name='ApplicationScope']/field[@name='CLOUDDRIVE_WRITE']"
		[Register ("CLOUDDRIVE_WRITE")]
		public const string ClouddriveWrite = (string) "clouddrive:write";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/auth/ApplicationScope", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplicationScope); }
		}

		protected ApplicationScope (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.auth']/class[@name='ApplicationScope']/constructor[@name='ApplicationScope' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ApplicationScope ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ApplicationScope)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
