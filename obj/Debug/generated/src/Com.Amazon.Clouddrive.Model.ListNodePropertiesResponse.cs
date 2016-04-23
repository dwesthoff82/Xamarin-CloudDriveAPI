using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodePropertiesResponse']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/ListNodePropertiesResponse", DoNotGenerateAcw=true)]
	public partial class ListNodePropertiesResponse : global::Java.Lang.Object, global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/ListNodePropertiesResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ListNodePropertiesResponse); }
		}

		protected ListNodePropertiesResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodePropertiesResponse']/constructor[@name='ListNodePropertiesResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ListNodePropertiesResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ListNodePropertiesResponse)) {
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

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCount);
			return cb_getCount;
		}

		static long n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ListNodePropertiesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodePropertiesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static Delegate cb_setCount_J;
#pragma warning disable 0169
		static Delegate GetSetCount_JHandler ()
		{
			if (cb_setCount_J == null)
				cb_setCount_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetCount_J);
			return cb_setCount_J;
		}

		static void n_SetCount_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListNodePropertiesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodePropertiesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Count = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		static IntPtr id_setCount_J;
		public virtual unsafe long Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodePropertiesResponse']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()J", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getCount);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodePropertiesResponse']/method[@name='setCount' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setCount", "(J)V", "GetSetCount_JHandler")]
			set {
				if (id_setCount_J == IntPtr.Zero)
					id_setCount_J = JNIEnv.GetMethodID (class_ref, "setCount", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCount_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCount", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ListNodePropertiesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodePropertiesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static Delegate cb_setData_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetData_Ljava_util_Map_Handler ()
		{
			if (cb_setData_Ljava_util_Map_ == null)
				cb_setData_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_util_Map_);
			return cb_setData_Ljava_util_Map_;
		}

		static void n_SetData_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListNodePropertiesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodePropertiesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Data = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		static IntPtr id_setData_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodePropertiesResponse']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/util/Map;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodePropertiesResponse']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setData", "(Ljava/util/Map;)V", "GetSetData_Ljava_util_Map_Handler")]
			set {
				if (id_setData_Ljava_util_Map_ == IntPtr.Zero)
					id_setData_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setData_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_ == null)
				cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_);
			return cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_;
		}

		static int n_CompareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListNodePropertiesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodePropertiesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse p0 = (global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodePropertiesResponse']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.CloudDriveResponse']]"
		[Register ("compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveResponse;)I", "GetCompareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_Handler")]
		public virtual unsafe int CompareTo (global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse p0)
		{
			if (id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveResponse;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveResponse;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
