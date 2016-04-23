using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountQuotaResponse']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/GetAccountQuotaResponse", DoNotGenerateAcw=true)]
	public partial class GetAccountQuotaResponse : global::Java.Lang.Object, global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/GetAccountQuotaResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetAccountQuotaResponse); }
		}

		protected GetAccountQuotaResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountQuotaResponse']/constructor[@name='GetAccountQuotaResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GetAccountQuotaResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (GetAccountQuotaResponse)) {
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

		static Delegate cb_getAvailable;
#pragma warning disable 0169
		static Delegate GetGetAvailableHandler ()
		{
			if (cb_getAvailable == null)
				cb_getAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAvailable);
			return cb_getAvailable;
		}

		static long n_GetAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Available;
		}
#pragma warning restore 0169

		static Delegate cb_setAvailable_J;
#pragma warning disable 0169
		static Delegate GetSetAvailable_JHandler ()
		{
			if (cb_setAvailable_J == null)
				cb_setAvailable_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetAvailable_J);
			return cb_setAvailable_J;
		}

		static void n_SetAvailable_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Available = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAvailable;
		static IntPtr id_setAvailable_J;
		public virtual unsafe long Available {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountQuotaResponse']/method[@name='getAvailable' and count(parameter)=0]"
			[Register ("getAvailable", "()J", "GetGetAvailableHandler")]
			get {
				if (id_getAvailable == IntPtr.Zero)
					id_getAvailable = JNIEnv.GetMethodID (class_ref, "getAvailable", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getAvailable);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvailable", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountQuotaResponse']/method[@name='setAvailable' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setAvailable", "(J)V", "GetSetAvailable_JHandler")]
			set {
				if (id_setAvailable_J == IntPtr.Zero)
					id_setAvailable_J = JNIEnv.GetMethodID (class_ref, "setAvailable", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAvailable_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAvailable", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLastCalculated;
#pragma warning disable 0169
		static Delegate GetGetLastCalculatedHandler ()
		{
			if (cb_getLastCalculated == null)
				cb_getLastCalculated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastCalculated);
			return cb_getLastCalculated;
		}

		static IntPtr n_GetLastCalculated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LastCalculated);
		}
#pragma warning restore 0169

		static Delegate cb_setLastCalculated_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLastCalculated_Ljava_lang_String_Handler ()
		{
			if (cb_setLastCalculated_Ljava_lang_String_ == null)
				cb_setLastCalculated_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastCalculated_Ljava_lang_String_);
			return cb_setLastCalculated_Ljava_lang_String_;
		}

		static void n_SetLastCalculated_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LastCalculated = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLastCalculated;
		static IntPtr id_setLastCalculated_Ljava_lang_String_;
		public virtual unsafe string LastCalculated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountQuotaResponse']/method[@name='getLastCalculated' and count(parameter)=0]"
			[Register ("getLastCalculated", "()Ljava/lang/String;", "GetGetLastCalculatedHandler")]
			get {
				if (id_getLastCalculated == IntPtr.Zero)
					id_getLastCalculated = JNIEnv.GetMethodID (class_ref, "getLastCalculated", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLastCalculated), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastCalculated", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountQuotaResponse']/method[@name='setLastCalculated' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLastCalculated", "(Ljava/lang/String;)V", "GetSetLastCalculated_Ljava_lang_String_Handler")]
			set {
				if (id_setLastCalculated_Ljava_lang_String_ == IntPtr.Zero)
					id_setLastCalculated_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLastCalculated", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLastCalculated_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastCalculated", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getQuota;
#pragma warning disable 0169
		static Delegate GetGetQuotaHandler ()
		{
			if (cb_getQuota == null)
				cb_getQuota = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetQuota);
			return cb_getQuota;
		}

		static long n_GetQuota (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Quota;
		}
#pragma warning restore 0169

		static Delegate cb_setQuota_J;
#pragma warning disable 0169
		static Delegate GetSetQuota_JHandler ()
		{
			if (cb_setQuota_J == null)
				cb_setQuota_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetQuota_J);
			return cb_setQuota_J;
		}

		static void n_SetQuota_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Quota = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getQuota;
		static IntPtr id_setQuota_J;
		public virtual unsafe long Quota {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountQuotaResponse']/method[@name='getQuota' and count(parameter)=0]"
			[Register ("getQuota", "()J", "GetGetQuotaHandler")]
			get {
				if (id_getQuota == IntPtr.Zero)
					id_getQuota = JNIEnv.GetMethodID (class_ref, "getQuota", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getQuota);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuota", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountQuotaResponse']/method[@name='setQuota' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setQuota", "(J)V", "GetSetQuota_JHandler")]
			set {
				if (id_setQuota_J == IntPtr.Zero)
					id_setQuota_J = JNIEnv.GetMethodID (class_ref, "setQuota", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setQuota_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQuota", "(J)V"), __args);
				} finally {
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
			global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse p0 = (global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountQuotaResponse']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.CloudDriveResponse']]"
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
