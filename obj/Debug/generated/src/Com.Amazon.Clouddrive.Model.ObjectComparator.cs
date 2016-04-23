using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ObjectComparator']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/ObjectComparator", DoNotGenerateAcw=true)]
	public partial class ObjectComparator : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/ObjectComparator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectComparator); }
		}

		protected ObjectComparator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_compare_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ObjectComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", "")]
		public static unsafe int Compare (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_compare_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compare_Ljava_lang_Object_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
