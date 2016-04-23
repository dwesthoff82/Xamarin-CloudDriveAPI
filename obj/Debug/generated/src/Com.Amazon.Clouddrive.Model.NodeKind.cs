using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='NodeKind']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/NodeKind", DoNotGenerateAcw=true)]
	public partial class NodeKind : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='NodeKind']/field[@name='ASSET']"
		[Register ("ASSET")]
		public const string Asset = (string) "ASSET";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='NodeKind']/field[@name='FILE']"
		[Register ("FILE")]
		public const string File = (string) "FILE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='NodeKind']/field[@name='FOLDER']"
		[Register ("FOLDER")]
		public const string Folder = (string) "FOLDER";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='NodeKind']/field[@name='GROUP']"
		[Register ("GROUP")]
		public const string Group = (string) "GROUP";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/NodeKind", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NodeKind); }
		}

		protected NodeKind (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='NodeKind']/method[@name='values' and count(parameter)=0]"
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
