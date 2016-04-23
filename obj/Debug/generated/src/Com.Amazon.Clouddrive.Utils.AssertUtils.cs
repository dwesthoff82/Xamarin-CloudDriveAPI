using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.utils']/class[@name='AssertUtils']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/utils/AssertUtils", DoNotGenerateAcw=true)]
	public partial class AssertUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/utils/AssertUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AssertUtils); }
		}

		protected AssertUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_assertNotNull_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.utils']/class[@name='AssertUtils']/method[@name='assertNotNull' and count(parameter)=2 and parameter[1][@type='V'] and parameter[2][@type='java.lang.String']]"
		[Register ("assertNotNull", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public static unsafe void AssertNotNull (global::Java.Lang.Object p0, string p1)
		{
			if (id_assertNotNull_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_assertNotNull_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "assertNotNull", "(Ljava/lang/Object;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_assertNotNull_Ljava_lang_Object_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_assertNotNullOrEmpty_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.utils']/class[@name='AssertUtils']/method[@name='assertNotNullOrEmpty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("assertNotNullOrEmpty", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void AssertNotNullOrEmpty (string p0, string p1)
		{
			if (id_assertNotNullOrEmpty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_assertNotNullOrEmpty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "assertNotNullOrEmpty", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_assertNotNullOrEmpty_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_assertNotNullOrEmpty_Ljava_util_Collection_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.utils']/class[@name='AssertUtils']/method[@name='assertNotNullOrEmpty' and count(parameter)=2 and parameter[1][@type='java.util.Collection&lt;V&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("assertNotNullOrEmpty", "(Ljava/util/Collection;Ljava/lang/String;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public static unsafe void AssertNotNullOrEmpty (global::System.Collections.ICollection p0, string p1)
		{
			if (id_assertNotNullOrEmpty_Ljava_util_Collection_Ljava_lang_String_ == IntPtr.Zero)
				id_assertNotNullOrEmpty_Ljava_util_Collection_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "assertNotNullOrEmpty", "(Ljava/util/Collection;Ljava/lang/String;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_assertNotNullOrEmpty_Ljava_util_Collection_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
