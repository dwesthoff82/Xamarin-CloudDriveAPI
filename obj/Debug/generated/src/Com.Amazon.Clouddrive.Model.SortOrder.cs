using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='SortOrder']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/SortOrder", DoNotGenerateAcw=true)]
	public partial class SortOrder : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='SortOrder']/field[@name='ASC']"
		[Register ("ASC")]
		public const string Asc = (string) "ASC";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='SortOrder']/field[@name='DESC']"
		[Register ("DESC")]
		public const string Desc = (string) "DESC";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/SortOrder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SortOrder); }
		}

		protected SortOrder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='SortOrder']/method[@name='values' and count(parameter)=0]"
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
