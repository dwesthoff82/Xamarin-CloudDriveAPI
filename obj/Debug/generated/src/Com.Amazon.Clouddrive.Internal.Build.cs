using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='Build']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/internal/Build", DoNotGenerateAcw=true)]
	public partial class Build : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='Build']/field[@name='SDK_AGENT']"
		[Register ("SDK_AGENT")]
		public const string SdkAgent = (string) "android-sdk/1.0.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='Build']/field[@name='SDK_VERSION']"
		[Register ("SDK_VERSION")]
		public const string SdkVersion = (string) "1.0.0";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/internal/Build", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Build); }
		}

		protected Build (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='Build']/constructor[@name='Build' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Build ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Build)) {
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
