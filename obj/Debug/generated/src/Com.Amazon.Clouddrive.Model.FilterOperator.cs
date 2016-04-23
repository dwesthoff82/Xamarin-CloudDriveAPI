using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='FilterOperator']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/FilterOperator", DoNotGenerateAcw=true)]
	public partial class FilterOperator : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='FilterOperator']/field[@name='BETWEEN']"
		[Register ("BETWEEN")]
		public const string Between = (string) "BTW";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='FilterOperator']/field[@name='EQUAL_TO']"
		[Register ("EQUAL_TO")]
		public const string EqualTo = (string) "EQ";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='FilterOperator']/field[@name='GREATER_THAN']"
		[Register ("GREATER_THAN")]
		public const string GreaterThan = (string) "GT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='FilterOperator']/field[@name='GREATER_THAN_OR_EQUAL']"
		[Register ("GREATER_THAN_OR_EQUAL")]
		public const string GreaterThanOrEqual = (string) "GE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='FilterOperator']/field[@name='LESS_THAN']"
		[Register ("LESS_THAN")]
		public const string LessThan = (string) "LT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='FilterOperator']/field[@name='LESS_THAN_OR_EQUAL']"
		[Register ("LESS_THAN_OR_EQUAL")]
		public const string LessThanOrEqual = (string) "LE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='FilterOperator']/field[@name='STARTS_WITH']"
		[Register ("STARTS_WITH")]
		public const string StartsWith = (string) "SW";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/FilterOperator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FilterOperator); }
		}

		protected FilterOperator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='FilterOperator']/method[@name='values' and count(parameter)=0]"
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
