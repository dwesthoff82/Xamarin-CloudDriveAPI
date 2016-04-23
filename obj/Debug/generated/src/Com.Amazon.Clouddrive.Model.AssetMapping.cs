using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='AssetMapping']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/AssetMapping", DoNotGenerateAcw=true)]
	public partial class AssetMapping : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='AssetMapping']/field[@name='ALL']"
		[Register ("ALL")]
		public const string All = (string) "ALL";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='AssetMapping']/field[@name='DESKTOP']"
		[Register ("DESKTOP")]
		public const string Desktop = (string) "DESKTOP";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='AssetMapping']/field[@name='MOBILE']"
		[Register ("MOBILE")]
		public const string Mobile = (string) "MOBILE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='AssetMapping']/field[@name='NONE']"
		[Register ("NONE")]
		public const string None = (string) "NONE";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/AssetMapping", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AssetMapping); }
		}

		protected AssetMapping (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='AssetMapping']/method[@name='values' and count(parameter)=0]"
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
