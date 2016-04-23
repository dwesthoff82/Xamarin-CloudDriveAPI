using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CaptureMode']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/CaptureMode", DoNotGenerateAcw=true)]
	public partial class CaptureMode : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CaptureMode']/field[@name='BURST']"
		[Register ("BURST")]
		public const string Burst = (string) "BURST";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CaptureMode']/field[@name='HDR']"
		[Register ("HDR")]
		public const string Hdr = (string) "HDR";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CaptureMode']/field[@name='LENTICULAR']"
		[Register ("LENTICULAR")]
		public const string Lenticular = (string) "LENTICULAR";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CaptureMode']/field[@name='NONE']"
		[Register ("NONE")]
		public const string None = (string) "NONE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CaptureMode']/field[@name='PANORAMA']"
		[Register ("PANORAMA")]
		public const string Panorama = (string) "PANORAMA";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CaptureMode']/field[@name='REWIND']"
		[Register ("REWIND")]
		public const string Rewind = (string) "REWIND";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CaptureMode']/field[@name='VIDSNAP']"
		[Register ("VIDSNAP")]
		public const string Vidsnap = (string) "VIDSNAP";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/CaptureMode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CaptureMode); }
		}

		protected CaptureMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CaptureMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Ljava/lang/String;", "")]
		public static unsafe string[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
