using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.internal.utils']/class[@name='StreamUtil']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/internal/utils/StreamUtil", DoNotGenerateAcw=true)]
	public partial class StreamUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/internal/utils/StreamUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StreamUtil); }
		}

		protected StreamUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.internal.utils']/class[@name='StreamUtil']/constructor[@name='StreamUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StreamUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StreamUtil)) {
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

		static IntPtr id_copyInputStreamToOutputStream_Ljava_io_InputStream_Ljava_io_OutputStream_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal.utils']/class[@name='StreamUtil']/method[@name='copyInputStreamToOutputStream' and count(parameter)=4 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("copyInputStreamToOutputStream", "(Ljava/io/InputStream;Ljava/io/OutputStream;IJ)J", "")]
		public static unsafe long CopyInputStreamToOutputStream (global::System.IO.Stream p0, global::System.IO.Stream p1, int p2, long p3)
		{
			if (id_copyInputStreamToOutputStream_Ljava_io_InputStream_Ljava_io_OutputStream_IJ == IntPtr.Zero)
				id_copyInputStreamToOutputStream_Ljava_io_InputStream_Ljava_io_OutputStream_IJ = JNIEnv.GetStaticMethodID (class_ref, "copyInputStreamToOutputStream", "(Ljava/io/InputStream;Ljava/io/OutputStream;IJ)J");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_copyInputStreamToOutputStream_Ljava_io_InputStream_Ljava_io_OutputStream_IJ, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
