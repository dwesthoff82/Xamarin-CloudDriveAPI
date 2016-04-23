using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.internal.utils']/class[@name='ThreadUtil']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/internal/utils/ThreadUtil", DoNotGenerateAcw=true)]
	public partial class ThreadUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/internal/utils/ThreadUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThreadUtil); }
		}

		protected ThreadUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.internal.utils']/class[@name='ThreadUtil']/constructor[@name='ThreadUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThreadUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ThreadUtil)) {
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

		static IntPtr id_checkIfInterrupted;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal.utils']/class[@name='ThreadUtil']/method[@name='checkIfInterrupted' and count(parameter)=0]"
		[Register ("checkIfInterrupted", "()V", "")]
		public static unsafe void CheckIfInterrupted ()
		{
			if (id_checkIfInterrupted == IntPtr.Zero)
				id_checkIfInterrupted = JNIEnv.GetStaticMethodID (class_ref, "checkIfInterrupted", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkIfInterrupted);
			} finally {
			}
		}

	}
}
