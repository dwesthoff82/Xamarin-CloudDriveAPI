using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Suppress']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/Suppress", DoNotGenerateAcw=true)]
	public sealed partial class Suppress : global::Java.Lang.Enum {


		static IntPtr Deduplication_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Suppress']/field[@name='Deduplication']"
		[Register ("Deduplication")]
		public static global::Com.Amazon.Clouddrive.Model.Suppress Deduplication {
			get {
				if (Deduplication_jfieldId == IntPtr.Zero)
					Deduplication_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Deduplication", "Lcom/amazon/clouddrive/model/Suppress;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Deduplication_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Suppress> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Process_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Suppress']/field[@name='Process']"
		[Register ("Process")]
		public static global::Com.Amazon.Clouddrive.Model.Suppress Process {
			get {
				if (Process_jfieldId == IntPtr.Zero)
					Process_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Process", "Lcom/amazon/clouddrive/model/Suppress;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Process_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Suppress> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr parameter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Suppress']/field[@name='parameter']"
		[Register ("parameter")]
		public string Parameter {
			get {
				if (parameter_jfieldId == IntPtr.Zero)
					parameter_jfieldId = JNIEnv.GetFieldID (class_ref, "parameter", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, parameter_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (parameter_jfieldId == IntPtr.Zero)
					parameter_jfieldId = JNIEnv.GetFieldID (class_ref, "parameter", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, parameter_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/Suppress", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Suppress); }
		}

		internal Suppress (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Suppress']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/Suppress;", "")]
		public static unsafe global::Com.Amazon.Clouddrive.Model.Suppress ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/Suppress;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Amazon.Clouddrive.Model.Suppress __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Suppress> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Suppress']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/amazon/clouddrive/model/Suppress;", "")]
		public static unsafe global::Com.Amazon.Clouddrive.Model.Suppress[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/clouddrive/model/Suppress;");
			try {
				return (global::Com.Amazon.Clouddrive.Model.Suppress[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Clouddrive.Model.Suppress));
			} finally {
			}
		}

	}
}
